using WindowsService1.Repository;

namespace WindowsService1.UseCases.User
{
  public class CreateUser : Base.IUseCase<Entities.User>
  {
    private readonly UserRepository userRepository;

    public CreateUser(UserRepository userRepository)
    {
      this.userRepository = userRepository;
    }

    public Entities.User Handle()
    {
      Entities.User? userExists = userRepository.FindByEmail("johndoe@email.com");

      if (userExists != null)
      {
        throw new Exception("User already exists");
      }

      Entities.User newUser = userRepository.Create(new Entities.User
      {
        Name = "John Doe",
        Email = "johndoe@email.com",
      });

      return newUser;
    }
  }
}