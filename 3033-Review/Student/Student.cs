using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set;}

        public Student()
        {
            ID = -900;
            FirstName = "";
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        public Student(int id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }
        public Student(int id)
        {
            ID = id;
            FirstName = "";
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }
        public string CreateFullName()
        {
            //same as return LastName + ", " + FirstName;
            return $"{LastName}, {FirstName}";

        }


    }



}
