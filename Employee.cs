using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecord
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public int Zip { get; set; }

        private List<Employee> Employees = new List<Employee>();

        public void AddEmployee()
        {


            try
            {

                Console.WriteLine("Enter Employee Id: ");
                int EnterId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                string EnterName = Console.ReadLine();
                Console.WriteLine("Enter Employee Address: ");
                string EnterAddress = Console.ReadLine();
                Console.WriteLine("Enter Employee Phone: ");
                int EnterPhone = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Cpuntry: ");
                string EnterCountry = Console.ReadLine();
                Console.WriteLine("Enter Employee Zip: ");
                int EnterZip = int.Parse(Console.ReadLine());
                Employees.Add(
                    new Employee()
                    {
                        Id = EnterId,
                        Name = EnterName,
                        Address = EnterAddress,
                        Phone = EnterPhone,
                        Country = EnterCountry,
                        Zip = EnterZip

                    });
                Console.WriteLine("Details Added Successfully:");
            }
            catch (Exception)
            {

                Console.WriteLine("Something went wrong, please try again");
                AddEmployee();

            }
        }
        public void DisplayStudents()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("ld\t\tName\t\tAddress\t\tPhone\t\tCountry");
            Employees.ForEach(Emp =>
            {
                Console.WriteLine(
                    Emp.Id + "\t\t" +
                    Emp.Name + "\t\t" +
                    Emp.Address + "\t\t" +
                    Emp.Phone + "\t\t" +
                    Emp.Country + "\t\t" + 
                    Emp.Zip + "\t\t\n"
                    );

            });
            Console.WriteLine("=====================================================");
        }

    }
}
