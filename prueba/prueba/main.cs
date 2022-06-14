using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome user");
            char opcion;

            do
            {


                Console.WriteLine("Desea calcular las operaciones \n 1.si \n 2.no");
                opcion = char.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case '1': menu menu = new menu(); menu.Menu(); break;
                    case '2' : Environment.Exit(0); break;
                    

                }
            }

            while (true);
            
        }
    }
}
