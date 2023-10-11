using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBusiness : IUserBusiness
    {
        private IUserRepository _res;
        public UserBusiness(IUserRepository res)
        {
            _res = res;
        }

		public List<UserModel> GetAllUser()
		{
			return _res.GetAllUser();
		}
		public UserModel GetDataByIdUser(string id)
        {
            return _res.GetDataByIdUser(id);
        }
        public bool UpdateUser(UserModel model)
        {
            return _res.UpdateUser(model);
        }

    }
}
