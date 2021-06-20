using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseManagementSystem
{
    class Driver
    {
         public BsCourseManagement bsCourse = BsCourseManagement.GetObj();
        
        public MsCourseManagement msCourse = MsCourseManagement.GetObj();
        public UgStudentManagement ug = UgStudentManagement.getObj();
        public PgStudentManagement pg = PgStudentManagement.getObj();
        public static void writeFile() {
            FileStream BS = new FileStream(@"C:\Users\VENOM\OneDrive\Documents\GitHub\CS57S62GID24\CourseManagementSystem\\BSCourse.txt", FileMode.OpenOrCreate);
            FileStream MS = new FileStream(@"C:\Users\VENOM\OneDrive\Documents\GitHub\CS57S62GID24\CourseManagementSystem\\MSCourse.txt", FileMode.OpenOrCreate);
            FileStream UG = new FileStream(@"C:\Users\VENOM\OneDrive\Documents\GitHub\CS57S62GID24\CourseManagementSystem\\UGstudent.txt", FileMode.OpenOrCreate);
            FileStream PG = new FileStream(@"C:\Users\VENOM\OneDrive\Documents\GitHub\CS57S62GID24\CourseManagementSystem\\PGStudent.txt", FileMode.OpenOrCreate);
            

        }
    }
}   
