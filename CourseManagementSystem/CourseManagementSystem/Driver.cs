using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class Driver
    {
       public BsCourseManagement bsCourse = BsCourseManagement.GetObj();
        public MsCourseManagement msCourse = MsCourseManagement.GetObj();
    }
}
