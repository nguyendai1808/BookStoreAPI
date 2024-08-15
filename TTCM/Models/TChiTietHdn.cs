using System;
using System.Collections.Generic;

namespace TTCM.Models;

public partial class TChiTietHdn
{
    public string SoHdn { get; set; } = null!;

    public string MaSach { get; set; } = null!;

    public int? Slnhap { get; set; }

    public virtual TSach MaSachNavigation { get; set; } = null!;

    public virtual THoaDonNhap SoHdnNavigation { get; set; } = null!;
}
