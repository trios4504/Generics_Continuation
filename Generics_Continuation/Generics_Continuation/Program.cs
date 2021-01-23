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
            Cakes weddingCake = new Cakes();
            weddingCake.AddFlavor<string>("Vanilla");

            Cakes partyCake = new Cakes();
            partyCake.AddFlavor<string>("Chocolate");


        }
    }
}

public class Cakes
{
    public void AddFlavor<F>(F parameter)
    {
        Console.WriteLine("The flavor for the Wedding cake is: " + weddingCake.AddFlavor + ".");
        Console.WriteLine("The flavor for the Party cake is: " + partyCake.AddFlavor + ".");
    }
}