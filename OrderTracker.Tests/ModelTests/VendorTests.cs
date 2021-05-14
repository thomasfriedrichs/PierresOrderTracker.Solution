using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable 
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndDesciption_ReturnsNameAndDesciption_StringString()
    {
      string description = "description";
      string name = "Test Name";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string description = "description";
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string description1 = "description1";
      string description2 = "desciption";
      string name01 = "name1";
      string name02 = "name2";
      Vendor newVendor1 = new Vendor(name01, description1);
      Vendor newVendor2 = new Vendor(name02, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Work";
      string name02 = "School";
      string description1 = "description1";
      string description2 = "desciption";
      Vendor newVendor1 = new Vendor(name01, description1);
      Vendor newVendor2 = new Vendor(name02, description2);
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor1, result);
    }


  }
}