using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class MsCourseManagement
    {
        private static MsCourseManagement obj ;
        public HashSet<MSCourses> MsCourseList = new HashSet<MSCourses>();
        public bool AddCourse(MSCourses course)
        {
            return MsCourseList.Add(course);
        }
        public bool DelCourse(MSCourses course)
        {
            return MsCourseList.Remove(course);
        }
        public bool UpdateCourse(MSCourses oldCourse, MSCourses newCourse)
        {
            this.DelCourse(oldCourse);
            return this.AddCourse(newCourse);
        }
        public HashSet<MSCourses> Search(String courseName)
        {
            HashSet<MSCourses> list = new HashSet<MSCourses>();
            HashSet<MSCourses>.Enumerator em = this.MsCourseList.GetEnumerator();
            while (em.MoveNext())
            {
                if (em.Current.CourseName.Contains(courseName))
                {
                    list.Add(em.Current);
                }
            }
            return list;
        }
        public static MsCourseManagement GetObj()
        {
            if (obj == null)
            {
                obj = new MsCourseManagement();
            }
            return obj;
        }
    }
}
