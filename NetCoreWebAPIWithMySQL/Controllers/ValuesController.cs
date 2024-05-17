using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebAPIWithMySQL.Models;

namespace NetCoreWebAPIWithMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly MyDbContext _myDbContext;
        public ValuesController(MyDbContext myDbContext) {
            _myDbContext  = myDbContext;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var data = _myDbContext.tbltest.ToList();
            return Ok(data);
        }
    }
}
