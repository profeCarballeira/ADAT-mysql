using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using _07_CRUD_navegacion.Models;

namespace _07_CRUD_navegacion.Controllers
{
    public class EmployeeController
    {
        private readonly string connectionString = 
            "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public List<Employee> GetAll()
        {
            var empleados = new List<Employee>();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT EmployeeID, FirstName, LastName, BirthDate FROM employees";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            empleados.Add(new Employee
                            {
                                EmployeeID = Convert.ToInt32(dr["EmployeeID"]),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                BirthDate = Convert.ToDateTime(dr["BirthDate"])
                            });
                        }
                    }
                }
                return empleados;
            }
        }


        public Employee GetById(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT EmployeeID, FirstName, LastName, BirthDate FROM employees WHERE EmployeeID = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Employee
                            {
                                EmployeeID = Convert.ToInt32(dr["EmployeeID"]),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                BirthDate = Convert.ToDateTime(dr["BirthDate"])
                            };
                        }
                    }
                }
            }

            return null;
        }


        public bool Delete(int id) {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM employees WHERE EmployeeID=@ID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }  
            }
          }

        public bool Insert(Employee emp)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO employees (FirstName, LastName, BirthDate)
                                VALUES (@FirstName, @LastName, @BirthDate)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(Employee emp)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE employees
                                 SET FirstName = @FirstName,
                                     LastName = @LastName,
                                     BirthDate = @BirthDate
                                 WHERE EmployeeID = @EmployeeID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                    cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                    cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }


}
