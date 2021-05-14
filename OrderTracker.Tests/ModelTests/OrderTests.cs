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

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string Title = "title";
      string Description = "Description";
      int Price = 1;
      Order newOrder = new Order(Title, Description, Price, "10/10/21");
      int result = newOrder.Price;
      Assert.AreEqual(Price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string Title = "title";
      string Description = "Description";
      int Price = 1;
      string Date = "april 4th, 2021";
      Order newOrder = new Order(Title, Description, Price, Date);
      string result = newOrder.Date;
      Assert.AreEqual(Date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string Title1 = "title1";
      string Description1 = "Description1";
      int Price1 = 1;
      string Date1 = "april 4th, 2021";
      string Title2 = "title2";
      string Description2 = "Description2";
      int Price2 = 2;
      string Date2 = "april 5th, 2021";
      Order newOrder1 = new Order(Title1, Description1, Price1, Date1);
      Order newOrder2 = new Order(Title2, Description2, Price2, Date2);
      List<Order> orderList = new List<Order> {newOrder1,newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string name01 = "name1";
      string name02 = "name2";
      string description1 = "description1";
      string description2 = "desciption2";
      int Price1 = 1;
      int Price2 = 2;
      string Date1 = "april 4th, 2021";
      string Date2 = "april 5th, 2021";
      Order newOrder1 = new Order(name01, description1, Price1, Date1);
      Order newOrder2 = new Order(name02, description2, Price2, Date2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

  }
}
