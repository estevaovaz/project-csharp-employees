using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Employees.Entity
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreasePorcente(Double p)
        {
            Salary += Salary * p / 100.0;
        }

        public override string ToString()
        {
            return Id
               + ", "
               + Name
               + ", "
               + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
