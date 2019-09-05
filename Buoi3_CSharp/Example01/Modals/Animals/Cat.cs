using System;
using System.Collections.Generic;
using System.Text;

namespace Example01.Modals.Animals
{
    public class Cat : Animal
    {
       public Cat()
        {

        }
        public override void ShowSound()
        {
            Console.WriteLine("meo..meo...");
        }
    }
}
