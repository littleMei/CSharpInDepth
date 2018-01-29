using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter2
{
    delegate void StringProcessor(string input);

    class Person
    {
        string name;
        public Person(string name) { this.name = name; }
        public void Say(string message) { Console.WriteLine("{0} says: {1}", name, message); }
    }
}
