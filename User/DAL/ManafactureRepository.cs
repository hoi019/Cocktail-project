using DAL.Interfaces;
using DataAccessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ManafactureRepository : IManafactureRespository
	{
		private IDatabaseHelper _db;
		public ManafactureRepository(IDatabaseHelper helper)
		{
			_db = helper;
		}
		public ManafactureModel GetDataById(int id)
		{
			string msgError = "";
			try
			{
				var dt = _db.ExecuteSProcedureReturnDataTable(out msgError, "sp_hien_thi_nha_san_xuat",
					 "@nId", id);
				if (!string.IsNullOrEmpty(msgError))
					throw new Exception(msgError);
				return dt.ConvertTo<ManafactureModel>().FirstOrDefault();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public bool Create(ManafactureModel md) 
		{
			string msgError = "";
			try
			{
				var result = _db.ExecuteScalarSProcedureWithTransaction(out msgError,
				"sp_them_nha_san_xuat",
				"@nTen", md.nTen,
				"@nSdt", md.nSdt,
				"@nDiaChi", md.nDiaChi,
				"@nEmail", md.nEmail);

				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public bool Update(ManafactureModel md)
		{
			string msgError = "";
			try
			{
				var result = _db.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_sua_nha_san_xuat",
				"@nId", md.nId,
				"@nTen", md.nTen,
				"@nSdt", md.nSdt,
				"@nDiaChi", md.nDiaChi,
				"@nEmail", md.nEmail);

				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public bool Delete(ManafactureModel md)
		{
			string msgError = "";
			try
			{
				var result = _db.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_xoa_nha_san_xuat",
				"@nId", md.nId);

				if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
				{
					throw new Exception(Convert.ToString(result) + msgError);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
