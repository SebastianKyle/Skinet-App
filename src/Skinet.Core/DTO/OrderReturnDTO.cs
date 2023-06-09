using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Skinet.Core.Domain.Entities.OrderAggregate;

namespace Skinet.Core.DTO
{
  public class OrderReturnDTO
  {
		public int Id { get; set; }
    public string BuyerEmail { get; set; }
    public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
    public Address ShipToAddress { get; set; }
    public string DeliveryMethod { get; set; }
		public decimal ShippingPrice { get; set; }
    public IReadOnlyList<OrderItemDTO> OrderItems { get; set; }
    public decimal SubTotal { get; set; }
		public decimal Total { get; set; }
    public string Status { get; set; }
  }
}