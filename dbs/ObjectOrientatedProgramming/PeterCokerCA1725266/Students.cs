using System;
using System.Collections;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Students : ICollection<Student>
    {
        public List<Student> StudentList = new List<Student>();

        public int Count
        {
            get { return StudentList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Student item)
        {
            StudentList.Add(item);
        }

        public void Clear()
        {
            StudentList.Clear();
        }

        public bool Contains(Student item)
        {
            return StudentList.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return StudentList.GetEnumerator();
        }

        public bool Remove(Student item)
        {
            return StudentList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SortList()
        {
            StudentList.Sort();
        }

        public Student GetStudent(int id)
        {
            Student student = null;

            foreach (Student pupil in StudentList)
            {
                if (pupil.StudentId.Equals(id))
                {
                    student = pupil;
                    break;
                }
            }

            return student;
        }
        public bool RemoveByID(int id)
        {
            Student studentDelete = GetStudent(id);
            bool removed = false;

            if (studentDelete != null)
            {
                StudentList.Remove(studentDelete);
                removed = true;
            }

            return removed;
        }

        public List<Student> GetStudentCurrent()
        {
            List<Student> isCurrentStudentList = new List<Student>();

            foreach (Student item in StudentList)
            {
                if (item.IsCurrentStudent == true)
                {
                    isCurrentStudentList.Add(item);
                }
            }

            return isCurrentStudentList;
        }

        public List<Student> GetStudentNotCurrent()
        {
            List<Student> isCurrentStudentList = new List<Student>();

            foreach (Student item in StudentList)
            {
                if (item.IsCurrentStudent == false)
                {
                    isCurrentStudentList.Add(item);
                }
            }

            return isCurrentStudentList;
        }

        public List<Student> GetPostgradStudent()
        {
            List<Student> postgradStudentList = new List<Student>();

            foreach (Student item in StudentList)
            {
                if (item.Status == StudentStatusEnum.Postgrad)
                {
                    postgradStudentList.Add(item);
                }
            }

            return postgradStudentList;
        }

        public List<Student> GetUndergradStudent()
        {
            List<Student> undergradStudentList = new List<Student>();

            foreach (Student item in StudentList)
            {
                if (item.Status == StudentStatusEnum.Undergrad)
                {
                    undergradStudentList.Add(item);
                }
            }

            return undergradStudentList;
        }


        public List<Student> GetUndergradStudentNotCurrent()
        {
            List<Student> undergradStudentsNotCurrentList = new List<Student>();

            foreach (Student item in StudentList)
            {
                if ((item.Status == StudentStatusEnum.Undergrad) && (item.IsCurrentStudent == false))
                {
                    undergradStudentsNotCurrentList.Add(item);
                }
            }

            return undergradStudentsNotCurrentList;
        }
    }
}
