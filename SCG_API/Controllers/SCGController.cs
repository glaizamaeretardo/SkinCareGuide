using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG_Common;
using SCG_BusinessLogic;
using SCG_DataLogic;


namespace SCG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCGController : ControllerBase
    {
        private static readonly InMemoryData data = new InMemoryData();
        private static readonly SCGProcess scgProcess = new SCGProcess(data);

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(scgProcess.GetAllUsers());
        }

        [HttpPost]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            scgProcess.AddUser(user);
            return Created("", user);
        }

        [HttpPatch]
        public ActionResult<string> UpdateUser([FromBody] User user)
        {
            scgProcess.UpdateUser(user.Name, (int)user.SkinType, out string newSkinType);
            return Ok(newSkinType);
        }

        [HttpDelete]
        public ActionResult DeleteUser([FromBody] User user)
        {
            scgProcess.DeleteUser(user);
            return Ok();
        }
    }
}