using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTCM.Repository;

namespace TTCM.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryRepository Context;

		public CategoryController(ICategoryRepository repository)
		{
			Context = repository;
		}

		[HttpGet]
		public IActionResult GetAll(int page = 0)
		{
			try
			{
				var result = Context.GetAllCategory(page);
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
		public IActionResult GetByName(string tenLoai = null, int page = 0)
		{
			try
			{
				var result = Context.GetAllByName(tenLoai, page);
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
