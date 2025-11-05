using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCG_BusinessLogic;
using SCG_Common;
using SCG_DataLogic;

namespace SCG_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCGController : ControllerBase
    {
        private readonly InMemoryData _data;
        private readonly SCGEmailService _emailService;

        public SCGController(InMemoryData data, SCGEmailService emailService)
        {
            _data = data;
            _emailService = emailService;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(_data.GetUsers());
        }

        [HttpPost]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            _data.AddUser(user);
            _emailService.SendUserSkinTypeEmail(user.Name, user.SkinType.ToString());

            return Created("", new
            {
                message = $"User “{user.Name}” has been successfully added, and a Mailtrap notification has been sent!",
                user
            });
        }

        [HttpPatch]
        public ActionResult<string> UpdateUser([FromBody] User user)
        {
            _data.UpdateUser(user);
            return Ok(user.SkinType.ToString());
        }

        [HttpDelete]
        public ActionResult DeleteUser([FromBody] User user)
        {
            _data.DeleteUser(user);
            return Ok();
        }
    }
}