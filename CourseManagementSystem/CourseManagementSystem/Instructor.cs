using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    interface Instructor:Person
    {
        string InstructorId
        {
            get;
            set;
        }
    }
}
