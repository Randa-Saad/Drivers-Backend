using Microsoft.Data.SqlClient;
using System.Data;
using Transflo.Models;

namespace Transflo.DAL
{
    public class Driver_DAL
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        public static IConfiguration Configuration { get; set; }

        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration= builder.Build();
            return Configuration.GetConnectionString("DefaultConnection");
        
        }

        public List<Driver> GetAll()
        {
            List<Driver> driverList = new List<Driver>();
            using (_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[usp_Get_Drivers]";
                _connection.Open();
                SqlDataReader dr = _command.ExecuteReader();

                while (dr.Read())
                {
                    Driver driver = new Driver();
                    driver.Id = Convert.ToInt32(dr["Id"]);
                    driver.FirstName = dr["FirstName"].ToString();
                    driver.LastName = dr["LastName"].ToString();
                    driver.Email = dr["Email"].ToString();
                    driver.PhoneNumber = dr["PhoneNumber"].ToString();
                    driverList.Add(driver);
                }
                _connection.Close();
            }
            return driverList;
        }

        public async Task<Response> Add(Driver model)
        {
            int id = 0;
            using (_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[usp_Insert_Driver]";
                _command.Parameters.AddWithValue("@FirstName", model.FirstName);
                _command.Parameters.AddWithValue("@LastName", model.LastName);
                _command.Parameters.AddWithValue("@Email", model.Email);
                _command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                _connection.Open();
                id = _command.ExecuteNonQuery();
                _connection.Close();    
            }
            if (id > 0)
            {
                return new Response() { Result = "added", KeyValue = model.FirstName };
            }
            else
            {
                return new Response() { Result = "fail", KeyValue = string.Empty };
            }
        }

        public async Task<Driver> GetById(int id)
        {
            Driver driver = new Driver();
            using (_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[usp_Get_DriverById]";
                _command.Parameters.AddWithValue("@Id", id);
                _connection.Open();
                SqlDataReader dr = _command.ExecuteReader();

                while (dr.Read())
                {
                    driver.Id = Convert.ToInt32(dr["Id"]);
                    driver.FirstName = dr["FirstName"].ToString();
                    driver.LastName = dr["LastName"].ToString();
                    driver.Email = dr["Email"].ToString();
                    driver.PhoneNumber = dr["PhoneNumber"].ToString();
                }
                _connection.Close();
            }
            return driver;
        }

        public async Task<Response> Update(Driver model)
        {
            int id = 0;
            using (_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[usp_Update_Driver]";
                _command.Parameters.AddWithValue("@Id", model.Id);
                _command.Parameters.AddWithValue("@FirstName", model.FirstName);
                _command.Parameters.AddWithValue("@LastName", model.LastName);
                _command.Parameters.AddWithValue("@Email", model.Email);
                _command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                _connection.Open();
                id = _command.ExecuteNonQuery();
                _connection.Close();
            }
            if (id > 0)
            {
                return new Response() { Result = "updated", KeyValue = model.FirstName };
            }
            else
            {
                return new Response() { Result = "fail", KeyValue = string.Empty };
            }
        }

        public async Task<Response> Remove(int id)
        {
            int deletedRowCount = 0;
            using (_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "[DBO].[usp_Delete_Driver]";
                _command.Parameters.AddWithValue("@Id", id);
                _connection.Open();
                deletedRowCount = _command.ExecuteNonQuery();
                _connection.Close();
            }
            if (deletedRowCount > 0)
            {
                return new Response() { Result = "removed", KeyValue = string.Empty };
            }
            else
            {
                return new Response() { Result = "fail", KeyValue = "Driver Not Exist" };
            }
        }


    }
}
