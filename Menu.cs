using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRecord
{
    class Menu
    {

        public int SelectMenu;
        public void DisplayMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Choose a menu item {1..5}");
            Console.WriteLine("1.Add Details");
            Console.WriteLine("2.Show Employee Details");
            Console.WriteLine("3.Edit Employee Details");
            Console.WriteLine("4.Detele Employee Detail");
            Console.WriteLine("5.Exit");
            SelectMenu = int.Parse(Console.ReadLine());

        }

    }
}
