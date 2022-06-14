using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class menu
    {
        public void Menu()
        {
            double subtransporte = 117_172;
            data data = new data();
            Console.WriteLine("Data of usuary");
            Console.WriteLine("Num document: ");
            data.Document = double.Parse(Console.ReadLine());
            Console.WriteLine("First Name: ");
            data.Firstname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            data.Lastname = Console.ReadLine();
            Console.WriteLine("Salary: ");
            data.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("worked days: ");
            data.Horas_trabajada = int.Parse(Console.ReadLine());
            /*Console.WriteLine("Ingreso Total: ");
            data.IngresoTotal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Devengo: ");
            data.Devengo = double.Parse(Console.ReadLine());
            Console.WriteLine("Salud: ");
            data.Salud = double.Parse(Console.ReadLine());
            Console.WriteLine("Pension: ");
            data.Pension = double.Parse(Console.ReadLine());*/


            if (data.Salary <= 2_000_000)
            {
                data.IngresoTotal1 = data.Salary + subtransporte;
            }
            else
            {
                data.IngresoTotal1 = data.Salary;
            }

            /*data.Devengo = data.Salary / 30;
            data.Devengo = data.Devengo * data.Horas_trabajada;*/

            data.Devengo = data.Salary * data.Horas_trabajada / 30;

            data.Salud = data.Horas_trabajada - 0.04;
            data.Pension = data.Horas_trabajada - 0.04;


            Console.WriteLine("Document: " + data.Document);
            Console.WriteLine("First Name: " + data.Firstname);
            Console.WriteLine("Last Name: " + data.Lastname);
            Console.WriteLine("Salary: " + data.Salary);
            Console.WriteLine("Worked Days: " + data.Horas_trabajada);
            Console.WriteLine("Ingreso Total: " + data.IngresoTotal1);
            Console.WriteLine("Devengo: " + data.Devengo);
            
        }
    }
}
