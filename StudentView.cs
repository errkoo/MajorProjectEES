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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MajorProjectEES
{
    public partial class StudentView : Form
    {
        private string filters = "";
        private DataTable resultTable;
        private string connectionString = @"Data Source=LAB108PC04\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";

        public StudentView()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '[Users]'", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable townsTable = new DataTable();

                adapter.Fill(townsTable);
                //columnsComboBox.DataSource = townsTable;
                columnsComboBox.DisplayMember = "COLUMN_NAME";
                columnsComboBox.ValueMember = "ORDINAL_POSITION";
                columnsComboBox.DataSource = townsTable;
                columnsComboBox.Enabled = true;
                textBox1.Enabled = false;
                columnsComboBox.SelectionChangeCommitted += columnsComboBox_SelectionChangeCommitted;
                filters = string.Empty;
                //columnsComboBox.SelectedIndexChanged += columnsComboBox_SelectedIndexChanged_1;
            }
        }
        private void columnsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filters += columnsComboBox.GetItemText(columnsComboBox.SelectedItem).Trim();
            columnsComboBox.Enabled = false;
            textBox1.Enabled = true;
        }
        private void StudentView_Load(object sender, EventArgs e)
        {
            LoadClasses();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from '[Users]", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                resultTable = new DataTable();
                adapter.Fill(resultTable);
                dataGridView1.DataSource = resultTable;
            }

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Photos'", con);
            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    adapter.SelectCommand = cmd;
            //    DataTable townsTable = new DataTable();

            //    adapter.Fill(townsTable);
            //    columnsComboBox.DataSource = townsTable;
            //    columnsComboBox.DisplayMember = "COLUMN_NAME";
            //    columnsComboBox.ValueMember = "ORDINAL_POSITION";
            //    columnsComboBox.Enabled = true;
            //    textBox2.Enabled = false;
            //}
            filters = string.Empty;
        }
       

        private void refresh_button_Click(object sender, EventArgs e)
        {
           int studentID;
                if (!int.TryParse(studentid_box.Text, out studentID))
                {
                    MessageBox.Show("ID should be an integer!");
                    return;
                }

                string query = @"
                SELECT st.FirstName, st.LastName, s.SubjectName, t.FirstName + ' ' + t.LastName as TeacherName, c.ClassTime, c.RoomNumber
                FROM Students st
                LEFT JOIN Enrollments e ON st.StudentID = e.StudentID
                LEFT JOIN Classes c ON e.ClassID = c.ClassID
                LEFT JOIN Subjects s ON c.SubjectID = s.SubjectID
                LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
                WHERE st.StudentID = @StudentID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string firstName = dataTable.Rows[0]["FirstName"].ToString();
                    string lastName = dataTable.Rows[0]["LastName"].ToString();
                    welcomeLabel.Text = $"Welcome {firstName} {lastName}";
                }
                else
                {
                    welcomeLabel.Text = "Student not found";
                }

                dataGridView1.DataSource = dataTable;
            }
        }
        private void enroll_button_Click(object sender, EventArgs e)
        {
          
                int studentID, classID;
                if (!int.TryParse(studentid_box.Text, out studentID))
                {
                    MessageBox.Show("Please enter a valid Student ID.");
                    return;
                }
                if (classesComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a class.");
                    return;
                }
                classID = Convert.ToInt32(classesComboBox.SelectedValue);

                string connectionString = @"Data Source=LAB108PC04\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = "INSERT INTO Enrollments (StudentID, ClassID) VALUES (@StudentID, @ClassID)";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@StudentID", studentID);
                        sqlCommand.Parameters.AddWithValue("@ClassID", classID);

                        sqlConnection.Open();
                        int result = sqlCommand.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Enrollment successful!");
                        else
                            MessageBox.Show("Enrollment failed.");
                    }
            }

        }
        private void LoadClasses()
        {
            string connectionString = @"Data Source=LAB108PC04\SQLEXPRESS; Initial Catalog=MajorProjectEES; Integrated Security=True;";
            string query = "SELECT ClassID, SubjectName + ' - ' + ClassTime as ClassName FROM Classes JOIN Subjects ON Classes.SubjectID = Subjects.SubjectID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                classesComboBox.DisplayMember = "ClassName";
                classesComboBox.ValueMember = "ClassID";
                classesComboBox.DataSource = dataTable;
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LogIn loginWindow = new LogIn();

            loginWindow.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            andButton.Enabled = true;
            orButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            filters = string.Empty;
            textBox1.Enabled = false;
            andButton.Enabled = false;
            orButton.Enabled = false;
            columnsComboBox.Enabled = true;
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(""))
            {
                filters += " Like '%" + textBox1.Text + "%'";
                MessageBox.Show(filters);
                filters += " AND ";
                textBox1.Text = "";
                textBox1.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(""))
            {
                filters += " Like '%" + textBox1.Text + "%'";
                MessageBox.Show(filters);
                filters += " OR ";
                textBox1.Text = "";
                textBox1.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(string.Empty))
            {
                filters += " Like '%" + textBox1.Text + "%'";
                MessageBox.Show(filters);
                DataView dv = resultTable.DefaultView;
                dv.RowFilter = filters;

                textBox1.Text = string.Empty;
                //filters = string.Empty;
                textBox1.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }
    }
}
