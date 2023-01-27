using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Dog : Animal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }

    public class Lion : Animal
    {
        public string speak()
        {
            return "Roar";
        }
    }

    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }
    public class Octopus : Animal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }

    public class Shark : Animal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }
}
