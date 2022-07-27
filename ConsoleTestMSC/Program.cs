using ConsoleTestMSC.Clases;
using ConsoleTestMSC.Configurations;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleTestMSC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Discount disc1 = new Discount(CustomerType.unregistered, 1.5E6m, 2022);
            Discount disc2 = new Discount(CustomerType.registered, 1.5E6m, 2022);
            Discount disc3 = new Discount(CustomerType.valuable, 1.5E6m, 2022);
            Discount disc4 = new Discount(CustomerType.most_valuable, 1.5E6m, 2022);

            Console.WriteLine(disc1.Calculate().ToString() + "\n" +
                              disc2.Calculate().ToString() + "\n" +
                              disc3.Calculate().ToString() + "\n" +
                              disc4.Calculate().ToString() + "\n");

        }
    }
}
