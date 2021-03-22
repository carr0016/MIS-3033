﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHW_GraduationHandout
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address(); //=null;
        }

        public Student (string firstName, string lastName, string major, double gpa) //overloaded constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
            Address = new Address();

        }
        public string CalculateDistinction()
        {
            string distinction; //making variable

            if (GPA >= 3.80)
            {
                distinction = "Summa Cum Laude";
            }
            else if (GPA >= 3.60)
            {
                distinction = "Magna Cum Laude";
            }
            else if (GPA>= 3.40)
            {
                distinction = "Cum Laude";
            }
            else
            {
                distinction = "No Distinction";
            }
            return distinction;
        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address = new Address(streetNumber, streetName, state, city, zipcode);
            //or Address.StreeNumber = streetNumber; 
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
        }
    }
}
