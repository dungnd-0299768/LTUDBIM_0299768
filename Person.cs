using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name;
        public int ChieuCao;
        public int weight;
        public bool isMale;
        public Person ( string Name, int ChieuCao, int weight,bool isMale )
        {
            this.Name = Name;
            this.ChieuCao = ChieuCao;
            this.weight = weight;   
            this.isMale = isMale;
        }
    }
}
