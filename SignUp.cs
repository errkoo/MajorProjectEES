using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.IO;

namespace MajorProjectEES
{
    public partial class SignUp : Form
    {
        private string sqlConnection = @"Data Source=LAB108PC04\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True";

        public SignUp()
        {
            InitializeComponent();
        }
        private void register_button_Click(object sender, EventArgs e)
        {
            string date = System.DateTime.Now.ToString();
            byte[] bytes = Encoding.UTF8.GetBytes(date);
            string hashed = HashPassword(password.Text, bytes);
            string role = string.Empty;
            try
            {
                if (student_button.Checked)
                    role = "Student";
                else
                    role = "Teacher";

                if (CheckUsername() && CheckNames() && CheckPassword())
                {
                    using (SqlConnection conn = new SqlConnection(sqlConnection))
                    {
                        conn.Open();
                        string query = $"Insert into Users(Username, Password, Date, Role) values " +
                            $"('{username.Text}', '{hashed}', '{date}', '{role}')";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();

                            query = $"SELECT UserID FROM Users WHERE Username=@Username";
                            cmd.CommandText = query;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Username", username.Text);

                            int userID = 0;
                            using (SqlDataReader oReader = cmd.ExecuteReader())
                            {
                                while (oReader.Read())
                                {
                                    userID = (int)oReader["UserID"];
                                }
                            }

                            if (role.Equals("Student"))
                            {
                                string query2 = $"Insert into Students(StudentID, FirstName, LastName) values " +
                                $"('{userID}', '{first_name.Text}', '{last_name.Text}')";

                                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                                {
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                            else if (role.Equals("Teacher"))
                            {
                                string query2 = $"Insert into Teachers(TeacherID, FirstName, LastName) values " +
                                $"('{userID}', '{first_name.Text}', '{last_name.Text}')";
                                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                                {
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    MessageBox.Show("Registration Succesfull");
                }
                else
                {
                    MessageBox.Show("Not succesfull");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void save_button_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(sqlConnection);
            conn.Open();
            string query = $"Update Users Set Image=@photo where Username =@Username";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@photo", saveImage());
            cmd.Parameters.AddWithValue("@Username", username.Text);
            MessageBox.Show("Saved Succesfully");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void browse_button_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }
        private bool CheckUsername()
        {
            if (username.Text == string.Empty)
            {
                MessageBox.Show("Username Not Complete", "Incorrect Username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    
        private bool CheckNames()
        {
            if (first_name.Text == string.Empty || last_name.Text == string.Empty)
            {
                MessageBox.Show("Enter Names", "Incorrect Names!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckPassword()
        {
            string text = password.Text;

            if (text.Length < 5 || !PasswordContainsChar())
            {
                MessageBox.Show("Try New Password", "Password Not Correct!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool PasswordContainsChar()
        {
            char[] arr = { '@', '!', '#', '$', '%', '^', '&', '*' };


            foreach (char c in arr)
            {
                if (password.Text.Contains(c.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        static string HashPassword(string password, byte[] salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenate password and salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                // Hash the concatenated password and salt
                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

                // Concatenate the salt and hashed password for storage
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
            }
        }
        private byte[] saveImage()
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logWindow = new LogIn();

            logWindow.Show();
            this.Hide();
        }
    }
}
