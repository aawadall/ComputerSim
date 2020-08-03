using CpuSim.Registers;
using PanelSim.Abstractions;
using System;
using System.Text;
using PanelSim.Implementations.Controllers;

namespace SimCli
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = new Word(24);
            // 0xA1 B2
            // 1010 0001 1011 0010 
            word.Set(new bool[] { true,false,true,false,false,false,false,true,true,false,true,true, false,false,true,false });
            Console.WriteLine($"Byte size = {word.ReadAsBytes().Length}");
            Console.WriteLine("Expecting 0xA1B2...");
            foreach (var item in word.ReadAsBytes())
            {
                Console.WriteLine( ((int)item).ToString("X"));
            }

            Console.WriteLine("Reporting bit value");
            Console.Write(" ");
            foreach (var item in word.Read())
            {
                Console.Write($"{(item ? 1 : 0)} ");
            }

            Console.WriteLine("Simulating Controllers ");

            IController led = new LedController("Simple", LedColor.Green);
            Console.WriteLine($"- Controller [{led.Label}] : State is [{led.State}]");
        }
    }
}
