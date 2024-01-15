using System;

namespace StudentProject.Models
{
    public enum SchoolClassType { ClassA, ClassB, ClassC}

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }

        public Student(string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
        }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.ClassA;
            EducationLevel = string.Empty;
        }

        public string HungarianFullName => $"{LastName} {FirstName}";
        public string HungarianBirthsDay => BirthsDay.ToString("yyyy.MM.dd.");
        public string HungarianLongBirthsDay => BirthsDay.ToString("yyyy.MM.dd. dddd");

        public string SchoolYearAndClass
        {
            get
            {
                string schoolClassName = string.Empty;
                switch (SchoolClass)
                {
                    case SchoolClassType.ClassA: schoolClassName = "a"; break;
                    case SchoolClassType.ClassB: schoolClassName = "b"; break;
                    case SchoolClassType.ClassC: schoolClassName = "c"; break;
                }
                if (schoolClassName != string.Empty)
                    return $"{SchoolYear}.{schoolClassName}";
                else
                    return $"{SchoolYear} évfolyam";
            }
        }

        public string AllProperty => $"{LastName} {FirstName} ({SchoolYearAndClass}) \n{HungarianBirthsDay}\n{EducationLevel}";

        public override string ToString()
        {
            return AllProperty;
        }
    }
}
