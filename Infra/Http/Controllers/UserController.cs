using Microsoft.AspNetCore.Mvc;
using WindowsService1.Entities;

namespace WindowsService1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    [HttpGet]
    public ActionResult<List<User>> Get()
    {
      return Ok(new List<User> {
        new User { Id = 1, Name = "John Doe", Email = "johndoe@email.com"},
        new User { Id = 2, Name = "Jane Doe", Email = "johndoe@email.com"}
      });
    }
  }
}