﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
		List<UserModel> GetAll();
		UserModel GetDataById(string id);
        bool Update(UserModel model);

    }
}
