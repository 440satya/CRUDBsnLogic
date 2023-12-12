using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDdtLogic.Model;

namespace CRUDdtLogic
{
    public class EmployeeDataLogic
    {
        private const string ConnectionString = "Data Source=.;Initial Catalog=Student;Integrated Security=SSPI";

        public static void AddEmployee(string name, string gender, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Salary", salary);

                    command.ExecuteNonQuery();
                }
            }
        }
        public List<EmployeeDt> GetTopEmployees(int count)
        {
            List<EmployeeDt> data = new List<EmployeeDt>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT TOP ({count}) [EmployeeId], [Name], [Gender], [Salary] FROM [Student].[dbo].[EmployeeTbl]";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeDt employeeData = new EmployeeDt
                        {
                            EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Salary = Convert.ToDecimal(reader["Salary"])
                        };

                        data.Add(employeeData);
                    }
                }
            }

            return data;
        }
    }
}
