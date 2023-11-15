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

		[HttpGet("get-all")]
		public IActionResult GetAllManafacture()
		{
			var dt = _bus.GetAllManafacture().Select(x => new { x.nId, x.nTen, x.nSdt, x.nDiaChi, x.nEmail });
			return Ok(dt);
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

		[Route("search-manafacture")]
		[HttpPost]
		public IActionResult Search([FromBody] Dictionary<string, object> formData)
		{
			try
			{
				var page = int.Parse(formData["page"].ToString());
				var pageSize = int.Parse(formData["pageSize"].ToString());
				string ten_khach = "";
				if (formData.Keys.Contains("ten") && !string.IsNullOrEmpty(Convert.ToString(formData["ten"]))) { ten_khach = Convert.ToString(formData["ten"]); }

				long total = 0;
				var data = _bus.SearchManafacture(page, pageSize, ten_khach, out total);
				return Ok(
					new
					{
						TotalItems = total,
						Page = page,
						PageSize = pageSize,
						Data = data
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
