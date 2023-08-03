namespace WindowsService1.Base
{
  public interface IUseCase<T>
  {
    T Handle();
  }
}