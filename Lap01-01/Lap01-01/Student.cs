using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap01_01
{
    internal class Student
    {
        //1. Field
        private string studentID;
        private string fullName;
        private int age;
        //2. Property
        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }

        //3.Constructor
        public Student() { }
        public Student(string studentID, string fullName, int age)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.age = age;
        }
        //4. Methods
        public void Input()
        {
            Console.Write("Nhập MSSV:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên:");
            FullName = Console.ReadLine();
            Console.Write("Nhập Tuổi:");
            Age = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Họ Tên:{1} Tuổi:{2}",
            this.StudentID, this.fullName, this.Age);
        }


    }
}
