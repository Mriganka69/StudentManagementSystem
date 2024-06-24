using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace SchoolManagementSystem
{
    public partial class AddStudentForm : UserControl
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mriga\OneDrive\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;");

        public AddStudentForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            displayStudentData();
        }

        public void displayStudentData()
        {
            try
            {
                List<AddStudentData> students = new AddStudentData().studentData();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("StudentID");
                dt.Columns.Add("StudentName");
                dt.Columns.Add("Email");

                foreach (var student in students)
                {
                    dt.Rows.Add(student.ID, student.StudentID, student.StudentName, student.Email);
                }

                student_studentData.DataSource = dt; // Assuming student_studentData is your DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void student_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(student_id.Text) ||
                string.IsNullOrWhiteSpace(student_name.Text) ||
                string.IsNullOrWhiteSpace(student_email.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                    using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                    {
                        checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                        int count = (int)checkSID.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Student ID: " + student_id.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO students (student_id, student_name, student_email) VALUES (@studentID, @studentName, @studentEmail)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentEmail", student_email.Text.Trim());
                                cmd.ExecuteNonQuery();

                                displayStudentData();
                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void clearFields()
        {
            student_id.Text = "";
            student_name.Text = "";
            student_email.Text = "";
        }

        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_email.Text == "" )
                
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Student ID: "
                            + student_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE students SET student_name = @studentName, " +
                                "student_email = @studentEmail " +
                                "WHERE student_id = @studentID ";



                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentEmail", student_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                cmd.ExecuteNonQuery();

                                displayStudentData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_studentData.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_email.Text = row.Cells[3].Value.ToString();
               
            }

        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                        connect.Open();

                    DialogResult check = MessageBox.Show("Are you sure you want to delete Student ID: " + student_id.Text.Trim() + "?",
                                                         "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        string deleteData = "DELETE FROM students WHERE student_id = @studentID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayStudentData(); // Refresh DataGridView
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("No rows deleted.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delete operation cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }



    }
}
        
    

