using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTCM.Models;
using TTCM.Repository;

namespace TTCM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ISachRepository sachContext;

        public BookController(ISachRepository sachRepository)
        {
            sachContext = sachRepository;
        }

        [HttpGet]
        public IActionResult GetAll(int page = 0)
        {
            try
            {
                var result = sachContext.GetAllBook(page);
                if(result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet("tenSach")]
        public IActionResult GetByName(string tenSach = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAllByName(tenSach, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("tenLoai")]
        public IActionResult GetbyCategory(string tenLoai = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAllByCategory(tenLoai, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("tenTG")]
        public IActionResult GetbyTacGia(string tenTG = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAllByTacGia(tenTG, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }

            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet("tenNXB")]
        public IActionResult GetbyNXB(string tenNXB = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAllByNXB(tenNXB, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("donGia")]
        public IActionResult GetbyDonGia(string donGia = null, string soSanh = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAllByDonGia(donGia, soSanh, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("khuyenMai")]
        public IActionResult GetbyKhuyenMai(string khuyenMai = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAllByKhuyenMai(khuyenMai, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }
            }
            catch
            {
                return BadRequest();
            }

        }


        [HttpGet("All In One")]
        public IActionResult GetAllbook(string tenSach = null, string tenLoai = null, string tenNXB = null, string tenTG = null,
            string donGia = null, string soSanh = null, string khuyenMai = null, int page = 0)
        {
            try
            {
                var result = sachContext.GetAll(tenSach, tenLoai, tenNXB, tenTG, donGia, soSanh, khuyenMai, page);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }

            }
            catch
            {
                return BadRequest();
            }

        }


    }
}
