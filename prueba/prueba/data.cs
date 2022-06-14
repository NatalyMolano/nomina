using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class data
    {
        private double document;
        private string firstname;
        private string lastname;
        private double salary;
        private int horas_trabajada;
        private double IngresoTotal;
        private double devengo;
        private double salud;
        private double pension;

        public double Document { get => document; set => document = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Horas_trabajada { get => horas_trabajada; set => horas_trabajada = value; }
        public double IngresoTotal1 { get => IngresoTotal; set => IngresoTotal = value; }
        public double Devengo { get => devengo; set => devengo = value; }
        public double Salud { get => salud; set => salud = value; }
        public double Pension { get => pension; set => pension = value; }
    }
}
