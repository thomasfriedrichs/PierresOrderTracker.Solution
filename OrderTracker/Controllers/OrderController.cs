using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrderController : Controller
  { 
    [HttpGet("/vendors/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> vendorOrders = new Dictionary<string, object>();
      vendorOrders.Add("order", order);
      vendorOrders.Add("vendor", vendor);
      return View(vendorOrders);
    }
  }
}
