using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_01
{
    public class Dog : Animal
{
    public new void Speak()
    {
        Console.WriteLine("Au Au!");
    }
}
}