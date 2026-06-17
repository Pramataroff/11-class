using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.Controller
{
    internal class GreensController
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Greens;Integrated Security=true;";

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void AddVegetable(Vegetable vegetable)
        {
            using (SqlConnection connect = GetConnection())
            {
                connect.Open();

                string sql = "INSERT INTO Vegetables (Name, Description, Price, VegetableTypeId) " +
                             "VALUES (@name, @description, @price, @vegetableTypeId);";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@name", vegetable.Name);
                    cmd.Parameters.AddWithValue("@description", vegetable.Description);
                    cmd.Parameters.AddWithValue("@price", vegetable.Price);
                    cmd.Parameters.AddWithValue("@vegetableTypeId", vegetable.VegetableTypeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddVegetableType(VegetableType vegetableType)
        {
            using (SqlConnection connect = GetConnection())
            {
                connect.Open();

                string sql = "INSERT INTO VegetableTypes (Name) " +
                             "VALUES (@name);";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@name", vegetableType.Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Vegetable> GetAllVegetables()
        {
            List<Vegetable> vegetables = new List<Vegetable>();

            using (SqlConnection connect = GetConnection())
            {
                connect.Open();

                string sql =
                    "SELECT v.Id, v.Name, v.Description, v.Price, v.VegetableTypeId, t.Name AS TypeName " +
                    "FROM Vegetables v " +
                    "INNER JOIN VegetableTypes t ON v.VegetableTypeId = t.Id;";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vegetable veg = new Vegetable
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            VegetableTypeId = Convert.ToInt32(reader["VegetableTypeId"]),
                            VegetableType = new VegetableType
                            {
                                Id = Convert.ToInt32(reader["VegetableTypeId"]),
                                Name = reader["TypeName"].ToString()
                            }
                        };

                        vegetables.Add(veg);
                    }
                }
            }

            return vegetables;
        }

        public List<VegetableType> GetAllTypes()
        {
            List<VegetableType> types = new List<VegetableType>();

            using (SqlConnection connect = GetConnection())
            {
                connect.Open();

                string sql = "SELECT Id, Name FROM VegetableTypes;";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        types.Add(new VegetableType
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }

            return types;
        }

        public void UpdateVegetable(Vegetable vegetable)
        {
            using (SqlConnection connect = GetConnection())
            {
                connect.Open();

                string sql =
                    "UPDATE Vegetables " +
                    "SET Name = @name, Description = @description, Price = @price, VegetableTypeId = @vegetableTypeId " +
                    "WHERE Id = @id;";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@name", vegetable.Name);
                    cmd.Parameters.AddWithValue("@description", vegetable.Description);
                    cmd.Parameters.AddWithValue("@price", vegetable.Price);
                    cmd.Parameters.AddWithValue("@vegetableTypeId", vegetable.VegetableTypeId);
                    cmd.Parameters.AddWithValue("@id", vegetable.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteVegetable(int id)
        {
            using (SqlConnection connect = GetConnection())
            {
                connect.Open();

                string sql = "DELETE FROM Vegetables WHERE Id = @id;";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}