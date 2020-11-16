using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Context;
using Testing.Models;
using Testing.Repositories.Base;

namespace Testing.Repositories
{
    public class ProductRepository : IBaseRepository<Product>
    {
        private readonly TestingDbContext _db;
        public DbSet<Product> _set;
        public ProductRepository(TestingDbContext db)
        {
            _db = db;
            _set = _db.Product;
        }

        public void Add(Product model)
        {
            _set.Add(model);
        }

        public IEnumerable<Product> GetAll()
        {
            return _set.ToList();
        }

        public Product GetById(int id)
        {
            return _set.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Product model)
        {
            _set.Remove(model);
        }

        public bool SaveChanges()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Update(Product model)
        {
            _set.Update(model);
        }
    }
}
