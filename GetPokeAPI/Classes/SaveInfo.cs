using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GetPokeAPI.Classes
{
    public static  class SaveInfo
    {
        public static void SaveData(string name, string job)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.SaveInfo", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Clear();
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
