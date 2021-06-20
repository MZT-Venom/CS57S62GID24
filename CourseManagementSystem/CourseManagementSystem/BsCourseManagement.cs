using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class BsCourseManagement
    {
        private static BsCourseManagement obj ;
        public HashSet<BSCourses> BsCourseList = new HashSet<BSCourses>();
        public bool AddCourse(BSCourses course)
        {
            return BsCourseList.Add(course);
        }
        public bool DelCourse(BSCourses course)
        {
            return BsCourseList.Remove(course);
        }
        public bool UpdateCourse(BSCourses oldCourse, BSCourses newCourse)
        {
            this.DelCourse(oldCourse);
            return this.AddCourse(newCourse);
        }
        public HashSet<BSCourses> Search(String courseName)
        {
            HashSet<BSCourses> list = new HashSet<BSCourses>();
            HashSet<BSCourses>.Enumerator em = this.BsCourseList.GetEnumerator();
            while (em.MoveNext())
            {
                if (em.Current.CourseName.Contains(courseName))
                {
                    list.Add(em.Current);
                }
            }
            return list;
        }
        public static BsCourseManagement GetObj()
        {
            if (obj == null)
            {
                 obj = new BsCourseManagement();
            }
            else
            {
               
            }
            return obj;
        }

    }
}
