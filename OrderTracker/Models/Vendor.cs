using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};

    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Description = vendorDescription;
      Name = vendorName;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
  }
}