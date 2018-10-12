using System;
using System.Collections;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Lists.TryCourseExample
{
    class Courses : ICollection<Course>
    {
        public List<Course> CourseList = new List<Course>();

        public int Count
        {
            get { return CourseList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Course item)
        {
            CourseList.Add(item);
        }

        public void Clear()
        {
            CourseList.Clear();
        }

        public bool Contains(Course item)
        {
            return CourseList.Contains(item);
        }

        public void CopyTo(Course[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return CourseList.GetEnumerator();
        }

        public bool Remove(Course item)
        {
            return CourseList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SortList()
        {
            CourseList.Sort();
        }

        public Course GetCourse(int courseCode)
        {
            Course course = null;

            foreach (Course courseSubject in CourseList)
            {
                if (courseSubject.CourseCode.Equals(courseCode))
                {
                    course = courseSubject;
                    break;
                }
            }

            return course;
        }

        public bool RemoveByCourseCode(int cousrseCode)
        {
            Course courseDelete = GetCourse(cousrseCode);
            bool removed = false;
            
            if (courseDelete != null)
            {
                CourseList.Remove(courseDelete);
                removed = true;
            }

            return removed;
        }

        public List<Course> GetCoursesRunning()
        {
            List<Course> courseRunningList = new List<Course>();

            foreach (Course course in courseRunningList)
            {
                if (course.Running == true)
                {
                    courseRunningList.Add(course);
                }
            }

            return courseRunningList;
        }


    }
}
