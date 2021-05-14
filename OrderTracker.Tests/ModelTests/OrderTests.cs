using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable 
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order", "description", 3, "10/10/21");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string Title = "Title";
      Order newOrder = new Order(Title, "description", 3, "10/10/21");
      string result = newOrder.Title;
      Assert.AreEqual(Title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string Title = "title";
      string Description = "Description";
      Order newOrder = new Order(Title, Description, 3, "10/10/21");
      string result = newOrder.Description;
      Assert.AreEqual(Description, result);
    }
  }
}
