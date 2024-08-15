using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTCM.Models;
using TTCM.Models.BookModel;

namespace TTCM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        QuanLyBanSachContext db = new QuanLyBanSachContext();

        public static List<Cart> carts = new List<Cart>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(carts);
        }

        [HttpPost]
        public bool Add(Book book)
        {
            foreach (var item in carts)
            {
                if (book.MaSach == item.MaSach)
                {
                    return false;
                }
            }
            var cart = new Cart
            {
                MaSach = book.MaSach,
                TenSach = book.TenSach,
                TenNxb = book.TenNxb,
                TenTheLoai = book.TenTheLoai,
                TacGia = book.TacGia,
                DonGiaBan = book.DonGiaBan,
                KhuyenMai = book.KhuyenMai,
                Anh = book.Anh
            };
            carts.Add(cart);
            return true;
        }


        [HttpDelete]
        public bool Delete(string maSach)
        {
            try
            {
                var cart = carts.FirstOrDefault(x => x.MaSach == maSach);
                if (cart == null)
                {
                    return false;
                }
                carts.Remove(cart);
                return true;
            }
            catch
            {
                return false;
            }  
        }

    }
}
