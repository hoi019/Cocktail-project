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
		private IUserBusiness _bus;
		public ManafactureController(IUserBusiness bus)
		{
			_bus = bus;
		}

		[HttpGet("get-by-id-nha-san-xuat")]
		public IActionResult GetDataById(string id)
		{
			var dt = _bus.GetDataById(id);
			return Ok(dt);
		}
		[AllowAnonymous]
		[HttpPost("create-nha-san-xuat")]
		public UserModel CreateManafacture([FromBody] UserModel md)
		{
			_bus.Create(md);
			return md;
		}
		[AllowAnonymous]
		[HttpPut("update-nha-san-xuat")]
		public UserModel UpdateManafacture([FromBody] UserModel md)
		{
			_bus.Update(md);
			return md;
		}
		[AllowAnonymous]
		[HttpDelete("delete-nha-san-xuat")]
		public UserModel DelteManafacture([FromBody] UserModel model)
		{
			_bus.Delete(model);
			return model;
		}
	}
}
