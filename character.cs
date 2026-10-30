using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class character
    {
        private int _health;
        public int Maxhealth {  get; set; }
        public int Health
        {
            get => _health; 
            set
            {
                if (value < 0) _health = 0;
                else if (value> Maxhealth)
                {
                    _health = Maxhealth;
                    Console.WriteLine("Gia tri" + value);
                }
                else _health = value;
            }
        }
    }
}
