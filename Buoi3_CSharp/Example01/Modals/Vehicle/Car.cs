using Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example01.Modals.Vehicle
{
    public class Car : Vehicle
    {
        public override void ShowSound()
        {
            Console.WriteLine("ping ping");
        }
    }
}
