using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IBillRepository
	{
		List<BillModel> GetAllBill();
		BillModel GetDatabyIDBill(int id);
		bool CreateBill(BillModel model);
		bool UpdateBill(BillModel model);
		List<StatisticsModel> StatisticsUser(int pageIndex, int pageSize, out long total, string ten_khach, DateTime? fr_NgayTao, DateTime? to_NgayTao);

	}
}
