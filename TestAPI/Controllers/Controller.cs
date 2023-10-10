using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;
using TestAPI.Data;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {
        private readonly ApiContext _context;
        public TestAPIController(ApiContext context)
        {
            _context = context;
        }

        //Create / edit
        [HttpPost]
        public JsonResult CreateEdit(TestAPI testAPI)
        {
            if(testAPI.Id == 0)
            {
                _context.TestAPI.Add(testAPI);
            }
            else
            {
                var testAPIInDb = _context.TestAPI.Find(testAPI.Id);

                if(testAPIInDb == null)
                {
                    return new JsonResult(NotFound());
                }

                testAPIInDb = api;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(TestAPI));
        }
    }
}