using Example01.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example01.Modals.Animals
{
    public abstract class Animal : ISound
    {

        private string name;
        private string foodtype;

        protected Animal()
        {
        }

        protected Animal(string name, string foodtype)
        {
            this.name = name;
            this.foodtype = foodtype;
        }

        public string Name { get => name; set => name = value; }
        public string Foodtype { get => foodtype; set => foodtype = value; }

        public abstract void ShowSound();
    }
}
