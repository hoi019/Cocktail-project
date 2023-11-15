using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IBillBusiness
	{
		List<BillModel> GetAllBill();
		BillModel GetDatabyIDBill(int id);
		bool CreateBill(BillModel model);
		bool UpdateBill(BillModel model);
		List<BillModel> SearchBill(int pageIndex, int pageSize, string ten_khach, out long total);
		List<StatisticsModel> StatisticsUser(int pageIndex, int pageSize, out long total, string ten_khach, DateTime? fr_NgayTao, DateTime? to_NgayTao);
	}
}
