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
      return this.createUser.Handle();
    }
  }
}