using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jon = new Person("Jon");
            Person tom = new Person("Tom");
            StringProcessor jonsVoice, tomsVoice, backgroud;
            jonsVoice = new StringProcessor(jon.Say);
            tomsVoice = new StringProcessor(tom.Say);
            backgroud = new StringProcessor(Background.Note);
            jonsVoice("Hello, son.");
            tomsVoice.Invoke("Hello, Daddy!");
            backgroud("An airplane flies past.");
            ReadLine();
        }

        
    }
}
