using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Testing.Repositories.Base;
using System.Linq;
using System.Threading.Tasks;
using Testing.Context;
using Testing.Models;

namespace Testing.Repositories
{
    public class BillRepository : IBaseRepository<Bill>
    {
        private readonly TestingDbContext _db;
        public DbSet<Bill> _set;
        public BillRepository(TestingDbContext db)
        {
            _db = db;
            _set = _db.Bill;
        }

        public void Add(Bill model)
        {
            _set.Add(model);
        }

        public IEnumerable<Bill> GetAll()
        {
            return _set.ToList();
        }

        public Bill GetById(int id)
        {
            return _set.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Bill model)
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

        public void Update(Bill model)
        {
            _set.Update(model);
        }
    }
}

