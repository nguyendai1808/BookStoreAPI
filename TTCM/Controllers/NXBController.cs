using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTCM.Models.BookModel;
using TTCM.Models;
using TTCM.Repository;

namespace TTCM.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NXBController : ControllerBase
	{
		private readonly INXBRepository Context;

		public NXBController(INXBRepository repository)
		{
			Context = repository;
		}

		[HttpGet]
		public IActionResult GetAll(int page = 0)
		{
			try
			{
				var result = Context.GetAllNXB(page);
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
		public IActionResult GetByName(string tenNXB = null, int page = 0)
		{
			try
			{
				var result = Context.GetAllByName(tenNXB, page);
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
