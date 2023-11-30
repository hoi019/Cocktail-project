using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private IProductBusiness _bus;
		public ProductController(IProductBusiness bus)
		{
			_bus = bus;
		}

		[HttpGet("get-all")]
		public IActionResult GetAllProduct()
		{
			var dt = _bus.GetAllProduct().Select(x => new { x.spId, x.sTen, x.sGia, x.sAnh, x.sSoLuong });
			return Ok(dt);
		}

		[HttpGet("get-by-id")]
		public IActionResult GetByIdProduct(string id)
		{
			var dt = _bus.GetByIdProduct(id);
			return Ok(dt);
		}

		[Route("filter-product")]
		[HttpPost]
		public IActionResult FilterProduct([FromBody] Dictionary<string, object> formData)
		{
			try
			{
				var index = int.Parse(formData["index"].ToString());
				long total = 0;
				var data = _bus.FilterProduct(index);
				return Ok(
					new
					{
						Data = data,
					}
					);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
