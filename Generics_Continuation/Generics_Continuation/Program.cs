using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Generics_Continuation;


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
        Console.WriteLine("The flavor for the cake is: " + parameter + ".");
    }
}