using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SchoolManagementSystem
{
    class AddStudentData
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mriga\OneDrive\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;");

        public List<AddStudentData> studentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            try
            {
                connect.Open();
                string sql = "SELECT * FROM students";
                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AddStudentData addSD = new AddStudentData
                        {
                            ID = (int)reader["id"],
                            StudentID = reader["student_id"].ToString(),
                            StudentName = reader["student_name"].ToString(),
                            Email = reader["student_email"].ToString()
                        };
                        listData.Add(addSD);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Database: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return listData;
        }

        public int ID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
    }
}
