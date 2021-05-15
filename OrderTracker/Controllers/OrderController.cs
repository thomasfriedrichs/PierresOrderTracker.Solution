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

  }
}
