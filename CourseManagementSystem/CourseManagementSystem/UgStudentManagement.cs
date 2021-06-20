using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class UgStudentManagement
    {
        private static UgStudentManagement obj;
        public HashSet<UnderGraduate> ugList = new HashSet<UnderGraduate>();
        public void Add(UnderGraduate st)
        {
            ugList.Add(st);
        }
        public void Del(UnderGraduate st)
        {
            ugList.Remove(st);
        }
        public void update(UnderGraduate oldSt,UnderGraduate newSt)
        {
            this.Del(oldSt);
            this.Add(newSt);
        }
        public HashSet<UnderGraduate> Search(String name)
        {
            HashSet<UnderGraduate> list = new HashSet<UnderGraduate>();
            HashSet<UnderGraduate>.Enumerator em = this.ugList.GetEnumerator();
            while (em.MoveNext())
            {
                if (em.Current.Name.Contains(name))
                {
                    list.Add(em.Current);
                }
            }
            return list;
        }
        public static UgStudentManagement getObj()
        {
            if (obj == null)
            {
                obj = new UgStudentManagement();
            }
            return obj;
        }
    }
}
