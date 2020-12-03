using System;
using Microsoft.Data.SqlClient;

namespace PracticeExerciseADO
{
    class Program
    {
        static void Main(string[] args)
        {

            DataAccess ado = new DataAccess();
            ado.CreateDatabase("try");
            ado.CreateTable("try", "tableA");
            ado.PopulateData("try", "tableA", 1, "A");
            ado.ShowData("try", "tableA");
        }
    }
}
