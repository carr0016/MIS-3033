using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = (File.ReadAllLines("rileystudentDataRandom100Rows.csv"));

            List<Student> students = new List<Student>();


            Student stud = new Student();
            stud.FirstName = "riley";
            stud.LastName = "Carr";
            stud.FavoriteColor = "blue";
            stud.ID = 1;
            Console.WriteLine(stud.CreateFullName());

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string pieces = line.Split(',');

                int id = Convert.ToInt32(pieces[0]);

                Student currentStudent = new Student()



            }

            ///foreach (var item in lines)
            ///{
           ///     Console.WriteLine(line);
          ///  }

            Console.ReadKey();





        }
    }
}
