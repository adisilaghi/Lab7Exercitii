using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Exercitii
{
    internal class Engine
    {
        private int cc;
        private int hp;
        private string fuelType;
        public Engine(int cc, int hp, string fuelType)
        {
            this.cc = cc;
            this.hp = hp;
            this.fuelType = fuelType;
        }
        public string GetDescription()
        {
            return $"{fuelType}, {cc}, {hp}";
        }
        public void engineStart()
        {
            Console.WriteLine("Brr");
        }
        public void engineStop()
        {
            Console.WriteLine("par poc pac");
        }
    }
}
