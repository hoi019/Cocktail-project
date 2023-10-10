using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IManafactureRespository
	{
		List<AccountModel> GetAll();
		ManafactureModel GetDataById(string id);
		bool Create(ManafactureModel md);
		bool Update(ManafactureModel md);
		bool Delete(ManafactureModel md);
	}
}
