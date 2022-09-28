using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Jesse",
                    LastName = "White",
                    EmployeeId = 007
                },
               new Employee()
               {
                   FirstName = "Walter",
                   LastName = "White",
                   EmployeeId = 008
               },
                new Employee()
                {
                    FirstName = "Joe",
                    LastName = "Schmoe",
                    EmployeeId = 002
                },
                 new Employee()
                 {
                     FirstName = "Joe",
                     LastName = "Toe",
                     EmployeeId = 003
                 },
                  new Employee()
                  {
                      FirstName = "Joe",
                      LastName = "Foe",
                      EmployeeId = 004
                  },
                   new Employee()
                   {
                       FirstName = "Chester",
                       LastName = "Walnut",
                       EmployeeId = 005
                   },
                   new Employee()
                    {
                        FirstName = "Luke",
                        LastName = "Skywalker",
                        EmployeeId = 001
                   },
                    new Employee()
            {
                FirstName = "Jose",
                LastName = "Smith",
                EmployeeId = 006
            },
                     new Employee()
            {
                FirstName = "Rick",
                LastName = "Sanchez",
                EmployeeId = 009
            },
                      new Employee()
            {
                FirstName = "Miachel",
                LastName = "Chriton",
                EmployeeId = 010
            },

            };
            List<Employee> EmployeeList2 = new List<Employee>();
            foreach (Employee paper in EmployeeList) // here we are creating the object
            {

                if (paper.FirstName == "Joe")
                {
                    EmployeeList2.Add(paper);
                    Console.WriteLine(paper.FirstName + paper.LastName);
                    Console.ReadLine();
                }




            }

            List<Employee> EmployeeList3 = EmployeeList.Where(z => z.FirstName == "Joe").ToList();
            foreach (Employee paper in EmployeeList) // Creating the "paper" allows us to look into the List and looking at the properties that belong to each item. paper is the object in the list that allows us to then tie in propeties
            {


                Console.WriteLine(paper.FirstName + paper.LastName);    
            }

            List<Employee> EmployeeList4 = EmployeeList.Where(t => t.EmployeeId > 5).ToList();
            foreach (Employee paper in EmployeeList)
            {
                Console.WriteLine (paper.FirstName);
            }

            Console.ReadLine();
        }
    }
}
