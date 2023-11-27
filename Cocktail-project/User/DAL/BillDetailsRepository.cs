﻿using DAL.Interfaces;
using DataAccessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class BillDetailsRepository : IBillDetaislRepository
	{
		private IDatabaseHelper _db;
		public BillDetailsRepository(IDatabaseHelper helper)
		{
			_db = helper;
		}
		public BillDetail GetAllByIdBill(int id)
		{
			string msgError = "";
			try
			{
				var dt = _db.ExecuteSProcedureReturnDataTable(out msgError, "sp_xem_chi_tiet_hoa_don_ban",
					 "@hdbId", id);
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<BillDetail>().FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
