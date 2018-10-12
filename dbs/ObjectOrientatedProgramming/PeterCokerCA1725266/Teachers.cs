using System;
using System.Collections;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Teachers : ICollection<Teacher>
    {
        public List<Teacher> TeacherList = new List<Teacher>();

        public int Count
        {
            get { return TeacherList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Teacher item)
        {
            TeacherList.Add(item);
        }

        public void Clear()
        {
            TeacherList.Clear();
        }

        public bool Contains(Teacher item)
        {
            return TeacherList.Contains(item);
        }

        public void CopyTo(Teacher[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Teacher> GetEnumerator()
        {
            return TeacherList.GetEnumerator();
        }

        public bool Remove(Teacher item)
        {
            return TeacherList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SortList()
        {
            TeacherList.Sort();
        }

        public Teacher GetTeacher(int id)
        {
            Teacher teacher = null;

            foreach (Teacher teachingStaff in TeacherList)
            {
                if (teachingStaff.EmployeeID.Equals(id))
                {
                    teacher = teachingStaff;
                    break;
                }
            }

            return teacher;
        }

        public bool RemoveByID(int id)
        {
            Teacher teacherDelete = GetTeacher(id);
            bool removed = false;

            if (teacherDelete != null)
            {
                TeacherList.Remove(teacherDelete);
                removed = true;
            }

            return removed;
        }

        public List<Teacher> GetTeacherCurrent
    }
}
