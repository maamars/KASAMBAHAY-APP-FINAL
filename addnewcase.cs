using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KASAMBAHAY_MANAGEMENT_SYSTEM
{
    public partial class addnewcase : Form
    {
        private static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public addnewcase()
        {
            InitializeComponent();
        }


    private void Savenewcase()
        {
            using (MySqlConnection conn1 = new MySqlConnection(connection))
            {
                try
                {
                    conn1.Open();
                    MySqlCommand cmd = conn1.CreateCommand();
                    cmd.CommandText = "INSERT INTO kasambahayaddnewcase (`Kasambahay_Name`, `Home_Address`, `Case_Name`, `Status`, `Date_Created`) VALUES (@Kasambahay_Name, @Home_Address, @Case_Name, @Status, @Date_Created)";
                    cmd.Parameters.AddWithValue("@Kasambahay_Name", $"{textBox1.Text} {textBox2.Text} {textBox3.Text}");
                    cmd.Parameters.AddWithValue("@Home_Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Case_Name", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Status", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Date_Created", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Case");


                    this.Close();
                    ClearInputs();
                    xMAIN main = new xMAIN();
                    main.Show();
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

        private void ClearInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Savenewcase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xMAIN main = new xMAIN();
            main.Show();
            this.Hide();
        }
    }
}
