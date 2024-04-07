using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Exercitii
{
    internal class Doors
    {
        private int doors;
        public Doors(int doors)
        {
            this.doors = doors;
        }
        public int GetDescription()
        {
            return doors;
        }
        public void Open()
        {
            Console.WriteLine("The doors are opening: click");
        }
        public void Close()
        {
            Console.WriteLine("The door are closing: clack");
        }
    }
}
