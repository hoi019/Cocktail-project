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
		public ManafactureModel GetDataById(string id)
		{
			return _res.GetDataById(id);
		}
		public bool Create(ManafactureModel md)
		{
			return _res.Create(md);
		}
		public bool Update(ManafactureModel md)
		{
			return _res.Update(md);
		}
		public bool Delete(string md)
		{
			return _res.Delete(md);
		}
	}
}
