using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    interface Person
    {
        //property declaration
        string Name
        {
            get;
            set;
        }
        string Email
        {
            get;
            set;
        }
        DateTime Dob
        {
            get;
            set;
        }
        string Cnic
        {
            get;
            set;
        }
    }
}
