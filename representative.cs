using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class RepresentativeForm : Form
    {
        private static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public RepresentativeForm()
        {
            InitializeComponent();
            LoadRepresentatives();
        }

        public void LoadRepresentatives()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT ID, Female_Employer, Male_Employer, 1st_Representative, Contact, Work, Age, Education, Name_of_School, Salary, 2nd_Representative, Contact_Number, Earnings FROM representative", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dt2.DataSource = dt;

                    foreach (DataGridViewColumn column in dt2.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Example method to add a new representative (excluding ID)
        public void AddRepresentative(string femaleEmployer, string maleEmployer, string firstRep, string contact, string work, int age, string education, string schoolName, decimal salary, string secondRep, string contactNumber, decimal earnings)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO representative (Female_Employer, Male_Employer, 1st_Representative, Contact, Work, Age, Education, Name_of_School, Salary, 2nd_Representative, Contact_Number, Earnings) VALUES (@Female_Employer, @Male_Employer, @1st_Representative, @Contact, @Work, @Age, @Education, @Name_of_School, @Salary, @2nd_Representative, @Contact_Number, @Earnings)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Female_Employer", femaleEmployer);
                    cmd.Parameters.AddWithValue("@Male_Employer", maleEmployer);
                    cmd.Parameters.AddWithValue("@1st_Representative", firstRep);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Work", work);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Education", education);
                    cmd.Parameters.AddWithValue("@Name_of_School", schoolName);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@2nd_Representative", secondRep);
                    cmd.Parameters.AddWithValue("@Contact_Number", contactNumber);
                    cmd.Parameters.AddWithValue("@Earnings", earnings);

                    cmd.ExecuteNonQuery();
                }

                // Reload the data to reflect the changes
                LoadRepresentatives();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
