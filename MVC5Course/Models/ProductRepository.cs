using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public override IQueryable<Product> All()
        {
            return base.All().Where(p => p.Active == true);
        }

        public IQueryable<Product> All(bool isGetAll)
        {
            if (isGetAll)
            {
                return base.All();
            }
            else
            {
                return this.All();
            }
        }

        public IQueryable<Product> Get���o�e��10���d�Ҹ��()
        {
            return this.Get���o�e��n���d�Ҹ��(10);
        }

        public IQueryable<Product> Get���o�e��n���d�Ҹ��(int n)
        {
            return this.All().Where(p => p.ProductId < n);
        }

        public Product GetByID(int? id)
        {
            return this.All().FirstOrDefault(p => p.ProductId == id.Value);
        }
    }

	public  interface IProductRepository : IRepository<Product>
	{

	}
}