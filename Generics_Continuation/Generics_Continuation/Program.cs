using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Generics_Continuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake<string> weddingCake = new Cake<string>();
            weddingCake.Flavor = "Vanilla";

            Cake<string> partyCake = new Cake<string>();
            partyCake.Flavor = "Chocolate";

            Console.WriteLine("The flavor for the Wedding cake is: " + weddingCake.Flavor + ".");
            Console.WriteLine("The flavor for the Party cake is: " + partyCake.Flavor + ".");

        }
    }
}

public class Cake<T>
{
    public string Flavor { get; set; }
}