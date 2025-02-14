using Microsoft.Data.SqlClient;

namespace WindowsFormAPPTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentId = this.studId.Text;
            string fullName = this.studName.Text;

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(fullName)) //if tha user does not comply to the input parameters
            {
                MessageBox.Show("Wrong. Try to write in a valid ID and an actual first name.");
                return;
            }


            //
            try
            {
                using var conn = new SqlConnection("Data Source=8300H\\SQLEXPRESS;Initial Catalog=Students_Oddi;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string query = "SELECT IsActive FROM Studlogin WHERE StudID = @StudID AND FullName = @FullName";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudID", studentId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    bool isActive = (bool)result;
                    if (isActive)
                    {
                        MessageBox.Show("Student is Enrolled in the Study program.");
                    }
                    else
                    {
                        MessageBox.Show("Student is not active in the Study program.");
                    }
                }
                else
                {
                    MessageBox.Show("Unknown Data or Re-enter correct ID and name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact Administrator\nPhone: 123-456-7890\nEmail: admin@university.com\nContact Timings: 9 AM - 5 PM");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
