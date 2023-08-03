namespace WindowsService1.Base
{
  public interface IRepository<T>
  {
    T Create(T entity);
    List<T> List();
    T Find(int id);
    T Update(int id, T entity);
    void Delete(int id);
  }
}