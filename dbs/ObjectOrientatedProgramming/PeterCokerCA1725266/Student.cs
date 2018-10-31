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
            return $"\nStudent ID: {StudentId}\nStudent Attendance: {IsCurrentStudent}\nStudent Name: {Name}\nStudent Status: {Status}\nStudent Phone: {Phone}\nStudent Email: {Email}";
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
