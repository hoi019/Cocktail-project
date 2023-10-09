using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IProductBusiness
	{
		ProductModel GetById(int id);
		bool Create(ProductModel model);
		bool Update(ProductModel model);
		bool Delete(ProductModel model);
	}
}
