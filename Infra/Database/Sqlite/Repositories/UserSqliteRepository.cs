using System.Data.SQLite;
using WindowsService1.Entities;

namespace WindowsService1.Repository
{
  public class UserSqliteRepository : UserRepository
  {
    private readonly string connectionString;

    public UserSqliteRepository()
    {
      connectionString = $"Data Source={System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "database.db")}";
    }

    public override User Create(User entity)
    {
      using SQLiteConnection connection = new(connectionString);
      connection.Open();

      using SQLiteCommand command = new(connection);
      command.CommandText = "INSERT INTO users (name, email) VALUES (@name, @email)";
      command.Parameters.AddWithValue("@name", entity.Name);
      command.Parameters.AddWithValue("@email", entity.Email);

      command.ExecuteNonQuery();
      entity.Id = (int?)connection.LastInsertRowId;

      return entity;
    }

    public override void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public override User Find(int id)
    {
      throw new NotImplementedException();
    }

    public override User? FindByEmail(string email)
    {
      using SQLiteConnection connection = new(connectionString);
      connection.Open();

      using SQLiteCommand command = new(connection);
      command.CommandText = "SELECT * FROM users WHERE email = @email";
      command.Parameters.AddWithValue("@email", email);

      using SQLiteDataReader reader = command.ExecuteReader();

      if (reader.Read())
      {
        return new User
        {
          Name = reader.GetString(1),
          Email = reader.GetString(2)
        };
      }
      else
      {
        return null;
      }
    }

    public override List<User> List()
    {
      throw new NotImplementedException();
    }

    public override User Update(int id, User entity)
    {
      throw new NotImplementedException();
    }
  }
}