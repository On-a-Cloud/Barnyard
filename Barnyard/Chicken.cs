using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CreateAFarm
{
    class Chicken
    {
        public void DisplayChicken()
        {
            ChickenSpeak();
            ChickenEat();
            ChickenProduct();
            ChickenHome();
        }

        public void ChickenSpeak()
        {
            Console.WriteLine("My name is Foghorn Leghorn the Chicken. I say pac pac ." + "\n");
        }
        public void ChickenEat()
        {
            Console.WriteLine("I eat seeds." + "\n");
        }

        public void ChickenProduct()
        {
            Console.WriteLine("I lay eggs for breakfast." + "\n");
        }
 
        public void ChickenHome()
        {
            Console.WriteLine("I live on the farm.");
        }
    }
}