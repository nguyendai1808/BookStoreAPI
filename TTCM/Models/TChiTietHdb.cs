using System;
using System.Collections.Generic;

namespace TTCM.Models;

public partial class TChiTietHdb
{
    public string SoHdb { get; set; } = null!;

    public string MaSach { get; set; } = null!;

    public int? Slban { get; set; }

    public virtual TSach MaSachNavigation { get; set; } = null!;

    public virtual THoaDonBan SoHdbNavigation { get; set; } = null!;
}
