using Exercicio_Employees.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  
            Console.Write("How many employees will be registered ? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #:" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine());

            Employees emp = list.Find(x => x.Id == id2);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreasePorcente(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employees obj in list)
            {

                Console.WriteLine(obj);
            }

            #endregion
        }
    }
}
