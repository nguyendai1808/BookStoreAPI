
using TTCM.Models.BookModel;

namespace TTCM.Repository
{
    public interface ISachRepository
    {
        List<Book> GetAllBook(int page);

        List<Book> GetAllByName(string tenSach, int page);

        List<Book> GetAllByCategory(string tenLoai, int page);

        List<Book> GetAllByNXB(string tenNXB, int page);

        List<Book> GetAllByTacGia(string tenTG, int page);

        List<Book> GetAllByDonGia(string donGia, string soSanh, int page);

        List<Book> GetAllByKhuyenMai(string khuyenMai, int page);

        List<Book> GetAll(string tenSach, string tenLoai, string tenNXB, string tenTG, string donGia, string soSanh, string khuyenMai, int page);

    }
}
