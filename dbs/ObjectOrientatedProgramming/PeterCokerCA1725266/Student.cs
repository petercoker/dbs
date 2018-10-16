using System;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Student : Person, IComparable
    {
        public int StudentId { get; set; }
        public bool IsCurrentStudent { get; set; }
        public StudentStatusEnum Status { get; set; }

        public Student()
        {

        }

        public Student(string name, int phone, string email, int studentId, bool isCurrentStudent, StudentStatusEnum status)
            : base(name, phone, email)
        {
            StudentId = studentId;
            IsCurrentStudent = isCurrentStudent;
            Status = status;
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}\nIs Student a current Student: {IsCurrentStudent}\nStudent: {Name}\nStatus: {Status}\nPhone: {Phone}\nEmail: {Email}\n";
        }

        public int CompareTo(object other)
        {
            int sort = -1;

            Student student = other as Student;

            if (other != null)
            {
                sort = this.StudentId.CompareTo(student.StudentId);
            }

            return sort;
        }
    }
}
