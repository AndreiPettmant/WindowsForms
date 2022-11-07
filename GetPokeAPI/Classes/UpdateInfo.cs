using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GetPokeAPI.Classes
{
    internal class UpdateInfo
    {
        public static void Update(string id, string name, string job)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.UpdatePessoa", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Nome", name);
                        command.Parameters.AddWithValue("@Emprego", job);
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
