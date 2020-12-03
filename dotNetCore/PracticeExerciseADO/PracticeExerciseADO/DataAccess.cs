
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace PracticeExerciseADO
{
    class DataAccess
    {

        public void CreateDatabase(string name)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "create database " + name;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void CreateTable(string dbname, string tableName)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=localhost;Initial Catalog=" + dbname + ";Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "create table " + tableName + "(id int, name varchar(30))";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void PopulateData(string dbname, string tablename, int id, string name)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=localhost;Initial Catalog=" + dbname + ";Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into " + tablename + " (id, name)" + " values(" + id + "," + "'" + name + "'" + ")";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void ShowData(string dbname, string tablename)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=localhost;Initial Catalog=" + dbname + ";Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from " + tablename;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0).ToString() + " " + reader.GetString(1));
            }
            sqlConnection.Close();
        }


    }
}