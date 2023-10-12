using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ManafactureController : Controller
	{
		private IManafactureBusiness _bus;
		public ManafactureController(IManafactureBusiness bus)
		{
			_bus = bus;
		}

		[HttpGet("get-by-id-nha-san-xuat")]
		public IActionResult GetDataById(string id)
		{
			var dt = _bus.GetDataByIdManafacture(id);
			return Ok(dt);
		}


		[HttpPost("create-nha-san-xuat")]
		public ManafactureModel CreateManafacture([FromBody] ManafactureModel md)
		{
			_bus.UpdateManafacture(md);
			return md;
		}


		[HttpPut("update-nha-san-xuat")]
		public ManafactureModel UpdateManafacture([FromBody] ManafactureModel md)
		{
			_bus.UpdateManafacture(md);
			return md;
		}


		[HttpDelete("delete-nha-san-xuat")]
		public IActionResult DelteManafacture(string model)
		{
			_bus.DeleteManafacture(model);
			return Ok(new { message = "xoa thanh cong" });
		}

	}
}
