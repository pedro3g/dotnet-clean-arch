namespace WindowsService1.UseCases.User
{
  public class CreateUser : Base.IUseCase<Entities.User>
  {
    public Entities.User Handle()
    {
      return new Entities.User
      {
        Id = 10,
        Name = "John Doe",
        Email = "johndoe@email.com"
      };
    }
  }
}