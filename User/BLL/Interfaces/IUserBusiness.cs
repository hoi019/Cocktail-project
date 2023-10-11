using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserBusiness
    {
		List<UserModel> GetAllUser();
		UserModel GetDataByIdUser(string id);
        bool UpdateUser(UserModel model);


    }
}
