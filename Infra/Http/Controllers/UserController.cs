using Microsoft.AspNetCore.Mvc;
using WindowsService1.UseCases.User;

namespace WindowsService1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly CreateUser createUser;

    public UserController(CreateUser createUser)
    {
      this.createUser = createUser;
    }

    [HttpPost]
    public ActionResult<Entities.User> Post()
    {
      try
      {
        Entities.User user = createUser.Handle();
        return Ok(user);
      }
      catch (Exception ex)
      {
        return BadRequest(new { message = ex.Message });
      }
    }
  }
}