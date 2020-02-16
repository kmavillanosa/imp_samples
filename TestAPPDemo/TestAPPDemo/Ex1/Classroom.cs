using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPPDemo
{

    /// <summary>
    /// Simulation of a classroom
    /// </summary>
    public class Classroom
    {
        public List<Student> Students { get; set; }

        public Classroom()
        {
            Students = new List<Student>();
        }

        /// <summary>
        /// Rule 1 : classroom must be able to enroll new students
        /// </summary>
        /// <param name="enrollee"></param>
        public void Enroll(string name, int age, Gender gender)
        {
            var enrollee = (new Student(name, age, gender));

            Students.Add(enrollee);

            Console.WriteLine($"Successfully enrolled student ${enrollee.Name}");

            GetStudentList();
        }

        /// <summary>
        /// Rule 2: can also expel students based on their name
        /// </summary>
        /// <param name="Name"></param>
        public void Expel(string name)
        {
            var student = Students.FirstOrDefault(st => st.Name.ToLower() == name.ToLower());
            if(student != null)
            {
                Console.WriteLine($"Successfully expelled student {student.Name}");
                GetStudentList();
            }
            else
            {
                Console.WriteLine("Student does not exist in this school");
            }
        }

        /// <summary>
        /// Rule 3: 
        /// </summary>
        public void GetStudentList()
        {
            var stringBuilder = new StringBuilder();

            foreach(var student in Students)
            {
                stringBuilder.AppendLine($"Name: {student.Name} | Age: {student.Age} | Gender: {student.Gender}");
            }

            Console.WriteLine(stringBuilder.ToString());
        }

    }
}
