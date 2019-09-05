using Example01.Interfaces;
using Example01.Modals.Animals;
using Example01.Modals.Humans;
using Example01.Modals.Vehicle;
using System;
using System.Collections.Generic;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISound> list = new List<ISound>();
            list.Add(new Cat());
            list.Add(new Dog());
            list.Add(new Car());
            list.Add(new People());
            for(int i = 0; i < list.Count; i++)
            {
                list[i].ShowSound();
            }
            Console.ReadLine();
        }
    }
}
