using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BT OPP
            Person person1 = new Person("Nam",175,67,true );
            Console.WriteLine(person1.Name + "\t" + person1.ChieuCao + "\t" + person1.weight + "\t"+ person1.isMale);

            // Mang class
            Person[] people = new Person[5];
            people[0] = new Person("Nam",175,55,true );
            people[1] = new Person("Linh", 160, 55, false);
            people[2] = new Person("Son", 145, 55, true); 
            people[3] = new Person("Tra", 168, 55, false);
            people[4] = new Person("Dao", 165, 55, true);
           Console.WriteLine("Ho ten\tChieu Cao\tCan nang\tGioi tinh");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(people[i].Name + "\t" + people[i].ChieuCao + "\t"+ "\t" + people[i].weight + "\t"+"\t" + people[i].isMale);
                Console.ReadLine();
            }

            //
            character character1= new character();
            character1.Health = 200;
            Console.WriteLine(character1.Health.ToString());




            // 
            Console.Write(" Nhap vao so a:");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap vao so b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap vao so c:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (c > b)
                {
                    Console.Write("Min:" + (b));
                }
                if (c < b)
                {
                    Console.Write("Min:" + (c));
                }
            }
            else
            {
                if (c > a)
                {
                    Console.Write("Min:" + (a));
                }
                if (c < a)
                {
                    Console.Write("Min:" + (c));
                }
            }
            Console.ReadLine();
        }
    }
}
