using System;

namespace StudentMVVMProjekt.Models
{
    public enum SchoolClassType { CLASS_A, CLASS_B, CLASS_C }

    public class Student
    {
        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.CLASS_A;
            EducationLevel = string.Empty;
        }

        public Student(string firstName, string lastName, DateTime birthsDay, int year, SchoolClassType schoolClass)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = year;
            SchoolClass = schoolClass;
            EducationLevel = string.Empty;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }       
    }
}