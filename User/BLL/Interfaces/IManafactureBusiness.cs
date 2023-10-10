using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IManafactureBusiness
	{
		List<ManafactureModel> GetAll();
		ManafactureModel GetDataById(string id);
		bool Create(ManafactureModel md);
		bool Update(ManafactureModel md);
		bool Delete(string id);
	}
}
