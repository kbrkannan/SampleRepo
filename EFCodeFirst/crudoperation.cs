
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class crudoperation
    {
        public void insertrecordforstudent()
        {
            using (var b = new College())
            {
                var s = new Student()
                {
                    Id = 1,
                    Name = "Boo",
                    Age = 20


                };
                b.students.Add(s);
                
                b.SaveChanges();

            }
        }
        public void insertrecordforCourse()
        {
            using (var b = new College())
            {
                
                var c = new Course()
                {
                    CourseId = 1,
                    Name = "C#"
                };
                b.courses.Add(c);
                b.SaveChanges();

            }
        }


        public void UpdateRecord()
        {
            using(var b = new College())
            {
                var s=b.students.First<Student>();
                s.Age = 22;
                b.SaveChanges();
            }
        }

        public void DeleteRecord()
        {
            using( var b = new College())
            {
                var s=b.courses.First<Course>();
                b.courses.Remove(s);
                b.SaveChanges();
            }
        }
        public void ReadRecord(string stname)
        {
            var b = new College();
            var s=b.students.Where(s=> s.Name == stname);
            foreach(var st in s)
            Console.WriteLine(st.Name+" "+st.Age);
        }
    }
}
