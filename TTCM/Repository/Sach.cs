using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;
using TTCM.Models;
using TTCM.Models.BookModel;

namespace TTCM.Repository
{
    public class Sach : ISachRepository
    {
        private readonly QuanLyBanSachContext _context;

        private static int PAGE_SIZE { get; set; } = 5;
        public Sach(QuanLyBanSachContext context) 
        {
            _context = context;
        }
        public List<Book> GetAllBook(int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.TenSach).AsQueryable();

            if (page == 0)
            {
                return books.ToList();
            }
            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }

        public List<Book> GetAllByName(string tenSach, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.TenSach).AsQueryable();

            if (!string.IsNullOrEmpty(tenSach))
            {
                books = books.Where(x => x.TenSach.Contains(tenSach));
            }

            if (page == 0)
            {
                return books.ToList();
            }

            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }

        public List<Book> GetAllByCategory(string tenLoai, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.TenTheLoai).AsQueryable();

            if (!string.IsNullOrEmpty(tenLoai))
            {
                books = books.Where(x => x.TenTheLoai.Contains(tenLoai));
            }

            if (page == 0)
            {
                return books.ToList();
            }
            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }
        public List<Book> GetAllByTacGia(string tenTG, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.TacGia).AsQueryable();

            if (!string.IsNullOrEmpty(tenTG))
            {
                books = books.Where(x => x.TacGia.Contains(tenTG));
            }

            if (page == 0)
            {
                return books.ToList();
            }
            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }
        public List<Book> GetAllByNXB(string tenNXB, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.TenNxb).AsQueryable();
            if (!string.IsNullOrEmpty(tenNXB))
            {
                books = books.Where(x => x.TenNxb.Contains(tenNXB));
            }

            if (page == 0)
            {
                return books.ToList();
            }

            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }


        public List<Book> GetAllByDonGia(string donGia, string soSanh, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.DonGiaBan).AsQueryable();

            if (soSanh == "<")
            {
                books = books.OrderByDescending(x => x.DonGiaBan).AsQueryable();
            }

            if (!string.IsNullOrEmpty(donGia))
            {
                switch (soSanh)
                {
                    case "<": books = books.Where(x => x.DonGiaBan <= Decimal.Parse(donGia));
                        break;
                    case ">": books = books.Where(x => x.DonGiaBan >= Decimal.Parse(donGia));
                        break;
                    default: books = books.Where(x => x.DonGiaBan == Decimal.Parse(donGia));
                        break;
                }
                
            }

            if (page == 0)
            {
                return books.ToList();
            }
            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }

        public List<Book> GetAllByKhuyenMai(string khuyenMai, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.KhuyenMai).AsQueryable();
            if (!string.IsNullOrEmpty(khuyenMai))
            {
                books = books.Where(x => x.KhuyenMai == Double.Parse(khuyenMai));
            }

            if (page == 0)
            {
                return books.ToList();
            }
            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }


        public List<Book> GetAll(string tenSach, string tenLoai, string tenNXB, string tenTG, string donGia, string soSanh, string khuyenMai, int page = 1)
        {
            var books = (from s in _context.TSaches
                         join tl in _context.TTheLoais on s.MaTheLoai equals tl.MaTheLoai
                         join nxb in _context.TNhaXuatBans on s.MaNxb equals nxb.MaNxb
                         join km in _context.TKhuyenMais on s.MaKm equals km.MaKm
                         into temp
                         from t in temp.DefaultIfEmpty()
                         select new Book
                         {
                             MaSach = s.MaSach,
                             TenSach = s.TenSach,
                             TacGia = s.TacGia,
                             TenTheLoai = tl.TenTheLoai,
                             TenNxb = nxb.TenNxb,
                             DonGiaBan = s.DonGiaBan,
                             KhuyenMai = t.KhuyenMai,
                             Anh = s.Anh

                         }).OrderBy(x => x.TenSach).AsQueryable();

            if (!string.IsNullOrEmpty(tenSach))
            {
                books = books.Where(x => x.TenSach.Contains(tenSach));
            }

            if (!string.IsNullOrEmpty(tenLoai))
            {
                books =  books.Where(x => x.TenTheLoai.Contains(tenLoai));
            }

            if (!string.IsNullOrEmpty(tenNXB))
            {
                books = books.Where(x => x.TenNxb.Contains(tenNXB));
            }

            if (!string.IsNullOrEmpty(tenTG))
            {
                books = books.Where(x => x.TacGia.Contains(tenTG));
            }

            if (soSanh == "<")
            {
                books = books.OrderByDescending(x => x.DonGiaBan).AsQueryable();
            }

            if (!string.IsNullOrEmpty(donGia))
            {
                switch (soSanh)
                {
                    case "<":
                        books = books.Where(x => x.DonGiaBan <= Decimal.Parse(donGia));
                        break;
                    case ">":
                        books = books.Where(x => x.DonGiaBan >= Decimal.Parse(donGia));
                        break;
                    default:
                        books = books.Where(x => x.DonGiaBan == Decimal.Parse(donGia));
                        break;
                }

            }

            if (!string.IsNullOrEmpty(khuyenMai))
            {
                books = books.Where(x => x.KhuyenMai == Double.Parse(khuyenMai));
            }

            if (page == 0)
            {
                return books.ToList();
            }
            var result = PaginatedList<Book>.Create(books, page, PAGE_SIZE);

            return result.ToList();
        }

    
    }
}
