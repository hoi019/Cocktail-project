using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBusiness _uBusiness;
        public UserController(IUserBusiness cBusiness)
        {
            _uBusiness = cBusiness;
        }

		[AllowAnonymous]
		[HttpGet("get-all")]
		public IActionResult GetAll()
		{
			var dt = _uBusiness.GetAllUser().Select(x => new { x.kId, x.kTen, x.kDiaChi});
			return Ok(dt);
		}

		[AllowAnonymous]
		[HttpGet("get-by-id")]
        public IActionResult GetDataById(string id)
        {
            var dt = _uBusiness.GetDataByIdUser(id);
            return Ok(dt);
        }

        [AllowAnonymous]
        [HttpPut("update-user")]
        public UserModel UpdateItem([FromBody] UserModel model)
        {
            _uBusiness.UpdateUser(model);
            return model;
        }
    }
}
