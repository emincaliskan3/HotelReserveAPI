using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        [HttpGet]
        public IActionResult StaffList()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddStaff(int id)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(int id)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            return Ok();
        }
    }
}
