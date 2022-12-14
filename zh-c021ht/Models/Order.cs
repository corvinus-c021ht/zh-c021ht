using System;
using System.Collections.Generic;

namespace zh_c021ht.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int OwnerFk { get; set; }

    public int BoatFk { get; set; }

    public int SailsFk { get; set; }

    public int? Db { get; set; }

    public bool? Active { get; set; }

    public virtual Boat BoatFkNavigation { get; set; } = null!;

    public virtual Owner OwnerFkNavigation { get; set; } = null!;

    public virtual Sails SailsFkNavigation { get; set; } = null!;
}
