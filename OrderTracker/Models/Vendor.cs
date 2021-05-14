using System.Collections.Generic;

namespace Vendor.Models
{
  public class Category
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
  }
}