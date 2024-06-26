using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using StreamingServiceModel;

namespace StreamingServiceDL
{
    public class SqlDbData
    {
        static string connectionString
        = "Data Source = LAPTOP-78G5SIK7\\SQLEXPRESS; Initial Catalog = StreamingService; Integrated Security = True;";

       static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect() 
        {
            sqlConnection.Open();
        }

        public List<User> GetMovie() 
{   
             List<User> movie = new List<User>();

        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    {
        string selectStatement = "SELECT title FROM users";
        SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

        sqlConnection.Open();

        using (SqlDataReader reader = selectCommand.ExecuteReader())
        {
            while (reader.Read())
            {
                User user = new User
                {
                    
                    Title = reader["title"].ToString()
                };

                movie.Add(user);
            }

            return movie;
        }
    }
}

        public void AddTitle(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string insertStatement = "INSERT INTO users VALUES (@title)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

               
                insertCommand.Parameters.AddWithValue("@title", user.Title);
                sqlConnection.Open();

                insertCommand.ExecuteNonQuery();

            
            }  

        }
        public void DeleteMovie(string title)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string deleteStatement = $"DELETE FROM users WHERE title = @title";
                SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);


                deleteCommand.Parameters.AddWithValue("@title", title).Value = title;

                sqlConnection.Open();

                deleteCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }           
        }
    }

}
