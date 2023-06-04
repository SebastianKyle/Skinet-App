using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Skinet.Core.Domain.Entities;
using Skinet.Core.Domain.Entities.OrderAggregate;
using Skinet.Core.ServiceContracts.PaymentServices;
using Stripe;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PaymentController : BaseApiController
  {
    private readonly IPaymentService _paymentService;
    private readonly ILogger<PaymentController> _logger;
    private const string WhSecret = "whsec_c5d8067448d058140b0b55773256e4181dbb78d219d48f9a2540c1b649dceccc"; // Webhooks secret

    public PaymentController(IPaymentService paymentService, ILogger<PaymentController> logger)
    {
      _paymentService = paymentService;
      _logger = logger;
    }

    [Authorize]
    [HttpPost("{basketId}")]
    public async Task<ActionResult<CustomerBasket>> CreateOrUpdatePaymentIntent(string basketId)
    {
      var basket = await _paymentService.CreateOrUpdatePaymentIntent(basketId);
      if (basket == null) 
      {
        return BadRequest(new ApiResponse(400, "Problem with your basket"));
      }

      return await _paymentService.CreateOrUpdatePaymentIntent(basketId);
    }

    [HttpPost("webhook")]
    public async Task<ActionResult> StripeWebHook()
    {
      var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
      var stripeEvent = EventUtility.ConstructEvent(json, Request.Headers["Stripe-Signature"], WhSecret);

      PaymentIntent intent;
      Order order;

      switch (stripeEvent.Type)
      {
        case "payment_intent.succeeded": 
          intent = (PaymentIntent) stripeEvent.Data.Object;
          _logger.LogInformation("Payment Succeeded: ", intent.Id);
          order = await _paymentService.UpdateOrderPaymentSucceeded(intent.Id);
          _logger.LogInformation("Order updated to payment received", order.Id);
          break;
        case "payment_intent.payment_failed":
          intent = (PaymentIntent) stripeEvent.Data.Object;
          _logger.LogInformation("Payment failed", intent.Id);
          order = await _paymentService.UpdateOrderPaymentFailed(intent.Id);
          _logger.LogInformation("Payment failed: ", order.Id);
          break;
      }

      return new EmptyResult();
    }
  }
}