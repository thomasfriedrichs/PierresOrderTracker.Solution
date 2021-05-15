using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class OrderController : Controller
  { 
    [HttpGet("/categories/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/items/{itemId}")]
    public ActionResult Show(int vendorId, int itemId)
    {
      Item item = Item.Find(itemId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> vendorOrders = new Dictionary<string, object>();
      vendorOrders.Add("item", item);
      vendorOrders.Add("vendor", vendor);
      return View(vendorOrders);
    }
  }
}
