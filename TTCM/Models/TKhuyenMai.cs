using System;
using System.Collections.Generic;

namespace TTCM.Models;

public partial class TKhuyenMai
{
    public string MaKm { get; set; } = null!;

    public double? KhuyenMai { get; set; }

    public virtual ICollection<TSach> TSaches { get; set; } = new List<TSach>();
}
