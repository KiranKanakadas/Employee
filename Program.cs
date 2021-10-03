using System;
using System.Collections.Generic;

namespace EmployeeRecord
{   
    public class MainClass
    {
        public static void Main(String[] args)
        {
            Console.Clear();
            var employee = new Employee();
            var menu = new Menu();
            menu.DisplayMenu();
            var m = menu.SelectMenu;
            while(m != 5)
            {
                if (m == 1)
                {
                    employee.AddEmployee();

                }
                else if (m == 2)
                {
                    employee.DisplayEmployee();
                }
                else if (m == 3)
                {
                    employee.EditEmployee();
                }
                //else if (m == 4)
                //{
                //    employee.DeleteEmployee();
                //}
                menu.DisplayMenu();
                m = menu.SelectMenu;
            }
        }   

    }
}
