using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CreateAFarm
{
    class Cow
    {
        public void DisplayCow()
        {
            CowSpeak();
            CowEat();
            CowProduct();
            CowHome();
        }
        public void CowSpeak()
        {
            Console.WriteLine("My name is Otis the Cow. I say Moooo." + "\n");
        }
 
        public void CowEat()
        {
            Console.WriteLine("I love to eat grass." + "\n");
        }

        public void CowProduct()
        {
            Console.WriteLine("I provide beef for Humans. And good Burgers!." + "\n");
        }

        public void CowHome()
        {
            Console.WriteLine("I live in the the farm.");
        }
    }
}