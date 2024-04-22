using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorProjectEES
{
    public partial class LogIn : Form
    {
        public string hashed = string.Empty;
        public string role = string.Empty;  
        public LogIn()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string sqlCon = @"Data Source=LAB108PC04\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";

            using (SqlConnection sqlConnection = new SqlConnection(sqlCon))
            {
                try
                {
                    usernameError.SetError(username, "");
                    passError.SetError(password, "");
                    if (CheckUsernameErrors() && CheckPasswordErrors())
                    {
                        

                        if (password.Text == password_2.Text)
                        {
                            sqlConnection.Open();

                            string Query1 = $"SELECT Date, Role FROM Users WHERE Username=@Username";

                            SqlCommand cmd = new SqlCommand(Query1, sqlConnection);
                            cmd.Parameters.AddWithValue("@Username", username.Text);

                            using (SqlDataReader oReader = cmd.ExecuteReader())
                            {
                                if (oReader.Read())
                                {
                                    string date = oReader["Date"].ToString();
                                    string role = oReader["Role"].ToString();

                                    byte[] bytes = Encoding.UTF8.GetBytes(date);
                                    string hashed = HashPassword(password.Text, bytes);

                                    string Query = $"SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";

                                    oReader.Close();

                                    cmd = new SqlCommand(Query, sqlConnection);
                                    cmd.Parameters.AddWithValue("@Username", username.Text);
                                    cmd.Parameters.AddWithValue("@Password", hashed);

                                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                                    if (count == 1)
                                    {
                                        if (role.Equals("Teacher"))
                                        {
                                            TeacherView teacherWindow = new TeacherView();
                                            teacherWindow.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            StudentView studentWindow = new StudentView();
                                            studentWindow.Show();
                                            this.Hide();

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Try again!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("User not found!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords should match!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private bool CheckPasswordErrors()
        {
            string pass = password.Text;
            char[] special = { '!', '@', '#', '$', '%', '^' };
            bool containsSpec = false;
            bool corrLenght = false;


            foreach (char c in special)
            {
                if (pass.Contains(c))
                {
                    containsSpec = true;
                }
                else
                {
                    passError.SetError(password, "Pass has to contain special character");
                }
            }
            if (pass.Length >= 5)
            {
                corrLenght = true;

            }
            else
            {
                passError.SetError(password, "Pass has to be 5 chars");

                corrLenght = false;
            }

            if (corrLenght && containsSpec)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckUsernameErrors()
        {

            bool corrLenght = false;

            string userName = username.Text;


            if (userName.Length >= 5)
            {
                corrLenght = true;

            }
            else
            {
                usernameError.SetError(username, "Username cannot be empty!");

                corrLenght = false;
            }

            if (corrLenght)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signWindow = new SignUp();

            signWindow.Show();
            this.Hide();
        }
    }
}
