using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Student : Person, IComparable
    {
        public int StudentId { get; set; }
        public StudentStatusEnum Status { get; set; }
        
        public Student()
        {

        }

        public Student(string name, int phone, string email, int studentId, StudentStatusEnum status)
            : base(name, phone, email)
        {
            StudentId = studentId;
            Status = status;
        }

        public override string ToString()
        {
            return base.ToString() + $"Student ID: {StudentId}\nStudent: {Name}\nStatus: {Status}\nPhone: {Phone}\nEmail: {Email}";
        }

        public int CompareTo(object other)
        {
            int sort = 0;

            Student student = other as Student;

            if (other != null)
            {
                sort = this.StudentId.CompareTo(student.StudentId);
            }

            return sort;
        }
    }
}
