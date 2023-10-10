using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IProductRespository
	{
		List<AccountModel> GetAll();
		ProductModel GetById(int id);
		bool Create(ProductModel model);
		bool Update(ProductModel model);
		bool Delete(ProductModel model);
	}
}
