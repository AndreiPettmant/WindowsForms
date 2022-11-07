using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace GetPokeAPI.Classes
{
    internal class DeleteInfo
    {
        public static void Delete(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using(SqlCommand command = new SqlCommand("dbo.DeletePessoa", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
