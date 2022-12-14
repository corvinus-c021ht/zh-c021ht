using System;
using System.Collections.Generic;

namespace zh_c021ht.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string? Name { get; set; }

    public string? ContactPhone { get; set; }

    public virtual ICollection<Boat> Boat { get; } = new List<Boat>();

    public virtual ICollection<Order> Order { get; } = new List<Order>();
}
