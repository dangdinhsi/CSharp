using Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example01.Modals.Humans
{
   public class People : ISound
    {
        public People()
        {

        }
        public void ShowSound()
        {
            Console.WriteLine("hehehehe");
        }
    }
}
