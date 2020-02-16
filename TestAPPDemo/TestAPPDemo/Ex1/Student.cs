using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{
    /// <summary>
    /// Enumerable is used for categories
    /// </summary>
    public enum Gender
    {
        Male,
        Female
    }

    /// <summary>
    /// Student class / object
    /// </summary>
    public class Student
    {

        /// <summary>
        /// Properties with 'private set' can set values within the class itself
        /// </summary>
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }

        public Student(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }


    }
}
