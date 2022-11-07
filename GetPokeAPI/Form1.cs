using GetPokeAPI.Classes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GetPokeAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAll();
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            var response = await RestHelper.Get(id);
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string job = txtJob.Text;

            var response = await RestHelper.Post(name,job);
            txtResponse.Text = RestHelper.BeautifyJson(response);
            SaveInfo.SaveData(name, job);
            Cleaner.ClearTextBox(this);
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string job = txtJob.Text;

            var response = await RestHelper.Put(id, name, job);
            txtResponse.Text = RestHelper.BeautifyJson(response);
            UpdateInfo.Update(id, name, job);
            Cleaner.ClearTextBox(this);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            var response = await RestHelper.Delete(id);
            txtResponse.Text = response;
            DeleteInfo.Delete(id);
            Cleaner.ClearTextBox(this);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            ShowDB(id);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadReport();
        }

        void ShowDB(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (String.IsNullOrEmpty(id))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.ShowDB", con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGrid.DataSource = dt;
                            }
                        }
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.SelectFromID", con))
                    {
                        try
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id", id);
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    dataGrid.DataSource = dt;
                                }
                            }
                        }
                        catch(System.Exception ex)
                        {
                            MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                        }
                    }
                }

                
            }
        }

        void DownloadReport()
        {
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\Report\\" + "dbreport.txt");

            try
            {
                string sLine = " ";

                for (int r = 0; r <= dataGrid.Rows.Count - 1; r++)
                {
                    for (int c = 0; c <= dataGrid.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGrid.Rows[r].Cells[c].Value;
                        if (c != dataGrid.Columns.Count - 1)
                        {
                            sLine = sLine + ", ";
                        }
                    }
                    streamWriter.WriteLine(sLine);
                    sLine = " ";
                }

                streamWriter.Close();
                System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                streamWriter.Close();
            }
        }
    }
}