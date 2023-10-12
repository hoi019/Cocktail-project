using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	public class ProductController : ControllerBase
	{
		private IProductBusiness _bus;
		public ProductController(IProductBusiness _bus)
		{
			_bus = _bus;
		}

		[HttpGet("get-all")]
		public IActionResult GetAllProduct()
		{
			var dt = _bus.GetAllProduct().Select(x => new { x.sTen, x.sGia, x.sAnh });
			return Ok(dt);
		}

		[HttpGet("get-by-id")]
		public IActionResult GetByIdProduct(string id)
		{
			var dt = _bus.GetByIdProduct(id);
			return Ok(dt);
		}

		[HttpPost("create-product")]
		public ProductModel CreateProduct([FromBody] ProductModel model)
		{
			_bus.CreateProduct(model);
			return model;
		}

		[HttpPut("update-product")]
		public ProductModel UpdateProduct([FromBody] ProductModel model)
		{
			_bus.UpdateProduct(model);
			return model;
		}

		[HttpDelete("delete-product")]
		public IActionResult DeleteProduct(string model)
		{
			_bus.DeleteProduct(model);
			return Ok(new { message = "xoa thanh cong" });
		}
	}
}
