using System;
using System.Collections.Generic;

namespace zh_c021ht.Models;

public partial class Sails
{
    public int SailId { get; set; }

    public string? SailName { get; set; }

    public double? Price { get; set; }

    public int? Db { get; set; }

    public virtual ICollection<Order> Order { get; } = new List<Order>();
}
