using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            OverallPriceCalculation price = new OverallPriceCalculation();
            price.InfoGather();
            Console.WriteLine(price.GetTotalMoviePrice());

        }
    }
}
