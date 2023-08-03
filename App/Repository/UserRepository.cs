using WindowsService1.Entities;

namespace WindowsService1.Repository
{
  public abstract class UserRepository : Base.IRepository<User>
  {
    public abstract User Create(User entity);
    public abstract void Delete(int id);
    public abstract User Find(int id);
    public abstract List<User> List();
    public abstract User Update(int id, User entity);
    public abstract User FindByEmail(string email);
  }
}