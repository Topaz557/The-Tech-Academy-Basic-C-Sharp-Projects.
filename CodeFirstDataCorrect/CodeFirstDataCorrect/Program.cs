using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeFirstDataCorrect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("What is the college name?");
                string name = Console.ReadLine();
                var college = new College { collegeName = name };
                db.Colleges.Add(college);
                db.SaveChanges();

                var query = from b in db.Colleges
                            orderby b.collegeName
                            select b;
                foreach (var item in query)
                {
                    Console.WriteLine(item.collegeName);
                }

                Console.Write("What is the students first name?");
                var firstName = Console.ReadLine();



                Console.Write("What is the students last name?");
                var lastName = Console.ReadLine();




                Console.Write("What is the students GPA?");
                decimal Gpa = Convert.ToDecimal(Console.ReadLine());

                var student = new StudentDB { FirstName = firstName, LastName = lastName, GPA = Gpa };


                db.StudentDBs.Add(student);
                db.SaveChanges();

                var query2 = from b in db.StudentDBs
                            orderby b.FirstName
                            select b;
                foreach (var item in query2)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.GPA);
                }
            }


        }
    }


    public class College
    {
        public int CollegeId { get; set; }
        public string collegeName { get; set; }
       
       
        public virtual List<StudentDB> StudentDBs { get; set; }
    }
    public class StudentDB
    {
        public int StudentDBId{ get; set; } // when defining the ID or primary key of a model it has to be named exacted name of the class then CAPTICAL I lower CASE d
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal GPA { get; set; }
        public virtual College college { get; set; }

    }
    public class StudentContext : DbContext
    {
        public DbSet<StudentDB> StudentDBs { get; set; }
        public DbSet<College>Colleges { get; set; }
    }
}