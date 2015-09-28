using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyvedi imeto si: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Vyvedi godinite si ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vyvedi naseleno mqsto: ");
            string mqsto = Console.ReadLine();
            Console.WriteLine("Imate li brat ili sestra? ");
            string imate = Console.ReadLine();
            Console.WriteLine("s kakvo se zanimavate");
            string zanimanie = Console.ReadLine();
            Console.WriteLine("S kakvo iskate da se zanimavate v bydeshte? ");
            string bydeshte = Console.ReadLine();
            Console.WriteLine("Priblizitelno kolko pari iskate da izkarvate? ");
            int pari = int.Parse(Console.ReadLine());
            Console.WriteLine("Vasheto ime e " + ime);
            Console.WriteLine("Vashite godini sa " + age);
            Console.WriteLine("Vasheto naseleno mqsto e " + mqsto);
            Console.WriteLine("Vie imate " + imate);
            Console.WriteLine("Zanimavate se v momenta sys " + zanimanie);
            Console.WriteLine("Vie iskate v bydeshte da se zanimavate sys " + bydeshte);
            Console.WriteLine("Vie iskate da izkarvate sumata " + pari + "lv");






        } 

        
    }
}
