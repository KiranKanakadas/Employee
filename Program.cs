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
                    employee.DisplayStudents();
                }
                //else if (m == 3)
                //{
                //    student.UpdateStudent();
                //}
                //else if (m == 4)
                //{
                //    student.DeleteStudent();
                //}
                menu.DisplayMenu();
                m = menu.SelectMenu;
            }
        }   

    }
}
