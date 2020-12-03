using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace StudentDAL
{
    class StudentRepo
    {
        SqlConnection con;
        SqlCommand command;
        public StudentRepo()
        {
            con = new SqlConnection("server=.\\sqlexpress;database=stdb;integrated security");
            command = new SqlCommand();
        }
        public List<Student> GetStudents()
        {
            command
        }
    }
}
