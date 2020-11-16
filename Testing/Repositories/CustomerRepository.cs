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
    public class CustomerRepository : IBaseRepository<Customer>
    {
        private readonly TestingDbContext _db;
        public DbSet<Customer> _set;
        public CustomerRepository(TestingDbContext db)
        {
            _db = db;
            _set = _db.Customer;
        }

        public void Add(Customer model)
        {
            _set.Add(model);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _set.ToList();
        }

        public Customer GetById(int id)
        {
            return _set.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Customer model)
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

        public void Update(Customer model)
        {
            _set.Update(model);
        }
    }
}
