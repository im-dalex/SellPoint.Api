using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Context;
using Testing.Repositories.Base;
using Testing.Models;


namespace Testing.Repositories
{
    public class BillDetailRepository : IBaseRepository<BillDetail>
    {
        private readonly TestingDbContext _db;
        public DbSet<BillDetail> _set;
        public BillDetailRepository(TestingDbContext db)
        {
            _db = db;
            _set = _db.BillDetail;
        }

        public void Add(BillDetail model)
        {
            
            _set.Add(model);
        }

        public IEnumerable<BillDetail> GetAll()
        {
            return _set.ToList();
        }

        public BillDetail GetById(int id)
        {
            return _set.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(BillDetail model)
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

        public void Update(BillDetail model)
        {
            _set.Update(model);
        }
    }
}
