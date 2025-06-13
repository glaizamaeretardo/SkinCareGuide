using Microsoft.Data.SqlClient;
using SCG_Common;

namespace SCG_DataLogic
{
    public class DBSkinCareData : ISkinCareData
    {
        static string connectionString =
            "Data Source=PC-202407181736\\SQLEXPRESS; Initial Catalog=SCGDataBase; Integrated Security=True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public DBSkinCareData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string insertStatement = "INSERT INTO SkinCareData (Name, SkinType) VALUES (@Name, @SkinType)";
                using (SqlCommand cmd = new SqlCommand(insertStatement, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@SkinType", user.SkinType.ToString());

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string selectStatement = "SELECT Name, SkinType FROM SkinCareData";

            using (SqlCommand cmd = new SqlCommand(selectStatement, sqlConnection))
            {
                sqlConnection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string skinTypeStr = reader["SkinType"].ToString();
                        if (Enum.TryParse(skinTypeStr, out SkinType skinTypeEnum))
                        {
                            users.Add(new User(name, skinTypeEnum));
                        }
                    }
                }
                sqlConnection.Close();
            }

            return users;
        }

        public bool UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string updateStatement = "UPDATE SkinCareData SET SkinType = @SkinType WHERE Name = @Name";
                using (SqlCommand cmd = new SqlCommand(updateStatement, conn))
                {
                    cmd.Parameters.AddWithValue("@SkinType", user.SkinType.ToString());
                    cmd.Parameters.AddWithValue("@Name", user.Name);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public bool DeleteUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string deleteStatement = "DELETE FROM SkinCareData WHERE Name = @Name";
                using (SqlCommand cmd = new SqlCommand(deleteStatement, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.Name);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
    }
}