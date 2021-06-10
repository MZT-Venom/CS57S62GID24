using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class PgStudentManagement
    {
        private static PgStudentManagement obj = null;
        public HashSet<PostGraduate> pgList = new HashSet<PostGraduate>();
        public void Add(PostGraduate st)
        {
            pgList.Add(st);
        }
        public void Del(PostGraduate st)
        {
            pgList.Remove(st);
        }
        public void update(PostGraduate oldSt, PostGraduate newSt)
        {
            this.Del(oldSt);
            this.Add(newSt);
        }
        public HashSet<PostGraduate> Search(String name)
        {
            HashSet<PostGraduate> list = new HashSet<PostGraduate>();
            HashSet<PostGraduate>.Enumerator em = this.pgList.GetEnumerator();
            while (em.MoveNext())
            {
                if (em.Current.Name.Contains(name))
                {
                    list.Add(em.Current);
                }
            }
            return list;
        }
        public static PgStudentManagement getObj()
        {
            if (obj == null)
            {
                obj = new PgStudentManagement();
            }
            return obj;
        }
    }
}
