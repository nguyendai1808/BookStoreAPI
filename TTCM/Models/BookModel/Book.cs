namespace TTCM.Models.BookModel
{
    public class Book
    {
        public string MaSach { get; set; } = null!;

        public string? TenSach { get; set; }

        public string? TacGia { get; set; }

        public string? TenTheLoai { get; set; }

        public string? TenNxb { get; set; }

        public decimal? DonGiaBan { get; set; }

        public double? KhuyenMai { get; set; }
        public string? Anh { get; set; }

    }
}
