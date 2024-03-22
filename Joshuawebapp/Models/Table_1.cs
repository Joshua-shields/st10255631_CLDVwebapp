using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Security.Policy;
using System.Data.SqlClient;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace Joshuawebapp.Models
{
    public class Table_1 : Controller
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }

    public class UserDataRepository 
    {
        
        public static string conString = "Server=tcp:st10255631.database.windows.net,1433;Initial Catalog=st10255631databaseclouddev;Persist Security Info=False;User ID=st10255631;Password= Mp3goo.cm15;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(conString);

        public int InsertUser(User user)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO userTable(username, userSurname, Useremail)" +
                             " VALUES (@Name, @Surname, @Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Surname", user.Surname);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
        }
    }


    public int insert_User(usertable n) {
            public IActionResult Index()
            {
                return View();
            }
        }
    }
