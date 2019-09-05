using Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example01.Modals.Vehicle
{
    public abstract class Vehicle : ISound
    {
       public Vehicle()
        {

        }
        public abstract void ShowSound();
    }
}
