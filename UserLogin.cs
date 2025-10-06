using librarys;
using System;
using System.IO;
using System.Windows.Forms;

namespace librarys
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validate login
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login Success!!!");
                mainDashbboard DB = new mainDashbboard();
                DB.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Denied!!!");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Path to the login data file
            string filePath = "C:\\Users\\MIKIMARE\\source\\repos\\librarys\\librarys\\loginData.txt";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Login data file not found.");
                return false;
            }

            // Read the file and check for matching credentials
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] credentials = line.Split(',');

                // Check if we have the right number of fields
                if (credentials.Length == 2)
                {
                    if (credentials[0].Trim() == username && credentials[1].Trim() == password)
                    {
                        return true; // Valid credentials found
                    }
                }
            }

            return false; // No valid credentials found
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Your code here...
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Your code here...
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Your code here...
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Your code here...
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Your code here...
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here...
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            // Your code here...
        }
    }
}
