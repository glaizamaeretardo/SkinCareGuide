using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG_Common;
using SCG_DataLogic;


namespace SCG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCGController : ControllerBase
    {
        private static readonly InMemoryData data = new InMemoryData();

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(data.GetUsers());
        }

        [HttpPost]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            data.AddUser(user);
            return Created("", user);
        }

        [HttpPatch]
        public ActionResult<string> UpdateUser([FromBody] User user)
        {
            data.UpdateUser(user);
            return Ok(user.SkinType.ToString());
        }

        [HttpDelete]
        public ActionResult DeleteUser([FromBody] User user)
        {
            data.DeleteUser(user);
            return Ok();
        }
    }
}