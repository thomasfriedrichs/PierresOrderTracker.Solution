using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendors.Models;
using System.Collections.Generic;
using System;

namespace Vendors.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}