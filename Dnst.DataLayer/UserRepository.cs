using Dnst.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnst.DataLayer
{
    public class UserRepository : IDisposable
    {
        private readonly SqlConnection _connection;

        public UserRepository(string databaseName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dnst"].ConnectionString;

            _connection = new SqlConnection(connectionString);
        }

        public UserModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<Models.UserModel>();

            _connection.Open();

            try
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("SELECT * FROM USERS");
                string command = builder.ToString();

                using (SqlCommand insertCommand = new SqlCommand(command, _connection))
                {
                    using (SqlDataReader reader = insertCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserModel model = new Models.UserModel();
                            model.Id = int.Parse(reader["Id"].ToString());
                            model.Name = reader["Name"].ToString();
                            model.Email = reader["Email"].ToString();
                            model.DateCreation = DateTime.Parse(reader["DateCreation"].ToString());

                            users.Add(model);
                        }
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return users;
        }
        
        public UserModel CreateUser(string name, string email, string password)
        {
            UserModel um = new UserModel();

            _connection.Open();

            try
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("declare @tempTable table(Id int, Name nvarchar(256), Email nvarchar(256), DateCreation datetime) ;");
                builder.AppendLine("INSERT INTO Users (Name, Email, [Password]) OUTPUT Inserted.Id, Inserted.Name, Inserted.Email, Inserted.DateCreation into @tempTable VALUES (@name, @email, @password);");
                builder.AppendLine("SELECT Id, Name, Email, DateCreation FROM @tempTable");

                string command = builder.ToString();

                using (SqlCommand insertCommand = new SqlCommand(command, _connection))
                {
                    SqlParameter nameParameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar) { Value = name };
                    SqlParameter emailParameter = new SqlParameter("@email", System.Data.SqlDbType.NVarChar) { Value = email };
                    SqlParameter passwordParameter = new SqlParameter("@password", System.Data.SqlDbType.NVarChar) { Value = password };

                    insertCommand.Parameters.AddRange(new SqlParameter[]
                    {
                        nameParameter,
                        emailParameter,
                        passwordParameter
                    });

                    using (SqlDataReader reader = insertCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            um.Id = reader.GetInt32(0);
                            um.Name = reader.GetString(1);
                            um.Email = reader.GetString(2);
                            um.DateCreation = reader.GetDateTime(3);
                        }
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return um;
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
