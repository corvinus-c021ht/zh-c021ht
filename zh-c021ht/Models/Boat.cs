using System;
using System.Collections.Generic;

namespace zh_c021ht.Models;

public partial class Boat
{
    public int BoatId { get; set; }

    public string? BoatName { get; set; }

    public int? OwnerFk { get; set; }

    public virtual ICollection<Order> Order { get; } = new List<Order>();

    public virtual Owner? OwnerFkNavigation { get; set; }
}
