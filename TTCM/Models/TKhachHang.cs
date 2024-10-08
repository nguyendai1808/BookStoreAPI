﻿using System;
using System.Collections.Generic;

namespace TTCM.Models;

public partial class TKhachHang
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public bool? GioiTinh { get; set; }

    public virtual ICollection<THoaDonBan> THoaDonBans { get; set; } = new List<THoaDonBan>();
}
