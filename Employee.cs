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
        public float Phone { get; set; }
        public int Zip { get; set; }

        private List<Employee> Employees = new List<Employee>();

        public void AddEmployee()
        {


            try
            {

                Console.WriteLine("Enter Employee Id: ");
                int EnterId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string EnterName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                string EnterAddress = Console.ReadLine();
                Console.WriteLine("Enter Phone number: ");
                float EnterPhone = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Country: ");
                string EnterCountry = Console.ReadLine();
                Console.WriteLine("Enter Zip: ");
                int EnterZip = int.Parse(Console.ReadLine());
                Employees.Add(
                    new Employee()
                    {
                        Id      = EnterId,
                        Name    = EnterName,
                        Address = EnterAddress,
                        Phone   = EnterPhone,
                        Country = EnterCountry,
                        Zip = EnterZip

                    });
                Console.WriteLine("Details Added Successfully:");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Something went wrong, please try again");
                AddEmployee();

            }
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("ld\t\tName\t\tAddress\t\tPhone\t\tCountry\t\tZip");
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
            Console.WriteLine("=============================================================================================");
        }
        public void EditEmployee()
        {
            try 
            {
                DisplayEmployee();
                Console.WriteLine("Enter the Employee Id of the Employee you want to edit");
                int Editid = int.Parse(Console.ReadLine());
                Employee editEmployee = Employees.Find(Edit => Edit.Id == Editid);
                if (editEmployee is null)
                {
                    Console.WriteLine("No Employee found with such Id, try agian");
                    EditEmployee();
                }
                Console.WriteLine("If you do not want to edit anything enter nothing");
                Console.WriteLine("Enter the Name: [" + editEmployee.Name + "]");
                string EditName = Console.ReadLine();
                if (EditName != "")
                {
                    editEmployee.Name = EditName;
                }
                Console.WriteLine("Enter the Address: [" + editEmployee.Address + "]");
                string EditAddress = Console.ReadLine();
                if (EditAddress != "")
                {
                    editEmployee.Address = EditAddress;
                }
                Console.WriteLine("Enter the Phone number: [" + editEmployee.Phone + "]");
                var EditPhone = Console.ReadLine() ?? null;
                if (!string.IsNullOrEmpty(EditPhone))
                {
                    float? t = float.Parse(EditPhone);
                    editEmployee.Phone = (int)t;
                }
                Console.WriteLine("Enter the Country: [" + editEmployee.Country + "]");
                string EditCountry = Console.ReadLine();
                if (EditCountry != "")
                {
                    editEmployee.Country = EditCountry;
                }
                Console.WriteLine("Enter the Zip: [" + editEmployee.Zip + "]");
                var EditZip = Console.ReadLine() ?? null;
                if (!string.IsNullOrEmpty(EditZip))
                {
                    int? t = int.Parse(EditZip);
                    editEmployee.Zip = (int)t;
                }
                DisplayEmployee();
            }
            catch(Exception) 
            {
                Console.WriteLine("Something went wrong, please try again");
                EditEmployee();
            }

            
        }
       

}
}
