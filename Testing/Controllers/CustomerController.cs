using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testing.Context;
using Testing.Controllers.Base;
using Testing.Models;
using Testing.Repositories.Base;

namespace Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController<Customer>
    {
        
        public CustomerController(IBaseRepository<Customer> repository) : base(repository)
        {
        }
    }
}
