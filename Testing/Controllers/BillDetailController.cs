using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testing.Controllers.Base;
using Testing.Models;
using Testing.Repositories.Base;

namespace Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillDetailController : BaseApiController<BillDetail>
    {
        public BillDetailController(IBaseRepository<BillDetail> repository) : base(repository)
        { }
    }
}
