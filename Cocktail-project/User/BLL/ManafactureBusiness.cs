using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class ManafactureBusiness : IManafactureBusiness
	{
		private IManafactureRespository _res;
		public ManafactureBusiness(IManafactureRespository res)
		{
			_res = res;
		}
		public List<ManafactureModel> GetAllManafacture()
		{
			return _res.GetAllManafacture();
		}
		public ManafactureModel GetDataByIdManafacture(string id)
		{
			return _res.GetDataByIdManafacture(id);
		}
		public bool CreateManafacture(ManafactureModel md)
		{
			return _res.CreateManafacture(md);
		}
		public bool UpdateManafacture(ManafactureModel md)
		{
			return _res.UpdateManafacture(md);
		}
		public bool DeleteManafacture(string md)
		{
			return _res.DeleteManafacture(md);
		}
	}
}
