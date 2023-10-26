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
	public class BillBusiness : IBillBusiness
	{
		private IBillRepository _res;
		public BillBusiness(IBillRepository res)
		{
			_res = res;
		}
		public BillModel GetDatabyIDBill(int id)
		{
			return _res.GetDatabyIDBill(id);
		}
		public bool CreateBill(BillModel model)
		{
			return _res.CreateBill(model);
		}
		public bool UpdateBill(BillModel model)
		{
			return _res.UpdateBill(model);
		}
		public List<StatisticsModel> StatisticsUser(int pageIndex, int pageSize, out long total, string ten_khach, DateTime? fr_NgayTao, DateTime? to_NgayTao)
		{
			return _res.StatisticsUser(pageIndex, pageSize, out total, ten_khach, fr_NgayTao, to_NgayTao);
		}
	}
}
