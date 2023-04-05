using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_01
{
    public class Cat : Animal
{
    public new void Speak()
    {
        Console.WriteLine("Miau!");
    }
}
}