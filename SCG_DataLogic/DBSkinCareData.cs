using Microsoft.Data.Sql;
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

        public void AddUser(User user)
        {
            string insertStatement = "INSERT INTO SkinCareData (Name, SkinType) VALUES (@Name, @SkinType)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Name", user.Name);
            insertCommand.Parameters.AddWithValue("@SkinType", user.SkinType.ToString());

            sqlConnection.Open();
            int rowsAffected = insertCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void DeleteUser(User user)
        {
            string deleteStatement = "DELETE FROM SkinCareData WHERE Name = @Name";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@Name", user.Name);

            sqlConnection.Open();
            int rowsAffected = deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            var selectStatement = "SELECT Name, SkinType FROM SkinCareData";

            using (var conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand(selectStatement, conn))
            {
                conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string skinTypeStr = reader["SkinType"].ToString();

                        SkinType skinTypeEnum = Enum.Parse<SkinType>(skinTypeStr);
                        users.Add(new User(name, skinTypeEnum));
                    }
                }
            }

            return users;
        }

        public void UpdateUser(User user)
        {
            string updateStatement = "UPDATE SkinCareData SET SkinType = @SkinType WHERE Name = @Name";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@SkinType", user.SkinType.ToString());
            updateCommand.Parameters.AddWithValue("@Name", user.Name);

            sqlConnection.Open();
            int rowsAffected = updateCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}