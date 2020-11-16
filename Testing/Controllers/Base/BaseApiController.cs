using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testing.Models.Base;
using Testing.Repositories.Base;

namespace Testing.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController<T> : Controller where T : class, IBaseEntity, new()
    {
        private readonly IBaseRepository<T> _db;
        public BaseApiController(IBaseRepository<T> db)
        {
            _db = db;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get()
        {
            return _db.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<T> Get(int id)
        {
            if (id < 1) return BadRequest();

            var model = _db.GetById(id);

            if (model == null) return NotFound();

            return Ok(model);

        }

        [HttpPost]
        public ActionResult<T> Post([FromBody] T model)
        {
            if (model == null) return BadRequest();

            _db.Add(model);

            var result = _db.SaveChanges();

            if (!result) return BadRequest(model);

            return Ok(model);
        }

        [HttpPut("{id}")]
        public ActionResult<T> Put(int id, [FromBody] T model)
        {
            if (model == null || id < 1)
            {
                return BadRequest(model);
            }

            var find = _db.GetById(id);
            if (find == null) return NotFound();

            _db.Update(model);

            var result = _db.SaveChanges();

            if (!result) return BadRequest(model);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<T> Delete(int id)
        {
            if (id < 1) return BadRequest();

            var find = _db.GetById(id);
            if (find == null) return NotFound();

            _db.Remove(find);

            var result = _db.SaveChanges();

            if (!result) return BadRequest();

            return NoContent();
        }
    }
}
