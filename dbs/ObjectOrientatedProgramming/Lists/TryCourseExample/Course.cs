using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Lists.TryCourseExample

{
    class Course : IComparable
    {
        public int CourseCode { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool Running { get; set; }
        public int NoOfModules { get; set; }

        public Course()
        {
            
        }

        public Course( int courseCode, string name, int level, bool running, int noOfModules)
        {
            CourseCode = courseCode;
            Name = name;
            Level = level;
            Running = running;
            NoOfModules = noOfModules;
        }

        public override string ToString()
        {
            return $"Course Code: {CourseCode}\nName: {Name}\nLevel: {Level}\nRunning: {Running}\nNumber of Modules: {NoOfModules}";
        }

        public int CompareTo(object other)
        {
            int sort = 0;

            Course course = other as Course;

            if (other != null)
            {
                sort = this.CourseCode.CompareTo(course.CourseCode);
            }

            return sort;
        }
    }
}
