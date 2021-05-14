using System.Collections.Generic;

namespace Vendors.Models
{
  public class Category
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public void Vendor(string vendorName)
    {
      Name = vendorName;
      Id = _vendors.Count;
      Orders = new List<Order>{};
    }
  }
}