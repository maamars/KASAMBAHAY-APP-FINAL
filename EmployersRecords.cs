using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class EmployersRecords : Form
    {
        private static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public EmployersRecords()
        {
            InitializeComponent();
            EmployersRecord();
            Representative();
        }

        private void EmployersRecord()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT ID, Female_Employer, Male_Employer, Address, Occupation, Age, Contact_Number, Civil_Status, No_of_Children, Salary FROM employersrecord", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
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

        private void SaveEmployersRecord()
        {
            using (MySqlConnection conn1 = new MySqlConnection(connection))
            {
                try
                {
                    conn1.Open();
                    MySqlCommand cmd = conn1.CreateCommand();
                    cmd.CommandText = "INSERT INTO employersrecord (Female_Employer, Male_Employer, Address, Occupation, Age, Contact_Number, Civil_Status, No_of_Children, Salary)" +
                        " VALUES (@EmployerNameF, @EmployerNameM, @Address, @Occupation, @Age, @ContactNumber, @CivilStatus, @NoofChildren, @Salary)";
                    cmd.Parameters.AddWithValue("@EmployerNameF", textBox16.Text);
                    cmd.Parameters.AddWithValue("@EmployerNameM", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Occupation", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox5.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", textBox25.Text);
                    cmd.Parameters.AddWithValue("@CivilStatus", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@NoofChildren", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Salary", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved in Employers records");
                    // After saving, reload data in dataGridView1
                    EmployersRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn1.Close();
                }
            }
        }

        private void Representative()
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

                    // Assuming you have a DataGridView named dataGridView2 in the current form for representatives
                    dataGridView2.DataSource = dt;

                    foreach (DataGridViewColumn column in dataGridView2.Columns)
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

        private void SaveRepresentativeRecord()
        {
            using (MySqlConnection conn1 = new MySqlConnection(connection))
            {
                try
                {
                    conn1.Open();
                    MySqlCommand cmd = conn1.CreateCommand();
                    cmd.CommandText = "INSERT INTO representative (Female_Employer, Male_Employer, 1st_Representative, Contact, Work, Age, Education, Name_of_School, Salary, 2nd_Representative, Contact_Number, Earnings)" +
                        " VALUES (@EmployerNameF, @EmployerNameM, @FirstRepresentative, @Contact, @Work, @Age, @Education, @NameOfSchool, @Salary, @SecondRepresentative, @ContactNumber, @Earnings)";
                    cmd.Parameters.AddWithValue("@EmployerNameF", textBox16.Text);
                    cmd.Parameters.AddWithValue("@EmployerNameM", textBox7.Text);
                    cmd.Parameters.AddWithValue("@FirstRepresentative", textBox28.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBox27.Text);
                    cmd.Parameters.AddWithValue("@Work", textBox18.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Education", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@NameOfSchool", textBox19.Text);
                    cmd.Parameters.AddWithValue("@Salary", textBox17.Text);
                    cmd.Parameters.AddWithValue("@SecondRepresentative", textBox26.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", textBox25.Text);
                    cmd.Parameters.AddWithValue("@Earnings", textBox21.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved in Representative records");
                    // After saving, reload data in dataGridView2
                    Representative();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn1.Close();
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            SaveEmployersRecord();
            SaveRepresentativeRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepresentativeForm rep = new RepresentativeForm();
            rep.Show();
        }
    }
}
