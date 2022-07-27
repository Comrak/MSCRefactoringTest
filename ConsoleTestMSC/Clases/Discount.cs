using ConsoleTestMSC.Clases.DiscountFormulas;
using ConsoleTestMSC.Configurations;
using ConsoleTestMSC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestMSC.Clases
{
    public class Discount : ICalculator
    {
        /*
            this class handles the creation of discount for any of the available customer types also contains the calcutate methos which aplies the 
            right static method to calculate the propper discount according to the customer type
        */
        public CustomerType type { get; set; }
        public decimal amount { get; set; }
        public int years { get; set; }

        public Discount(CustomerType type, decimal amount, int years)
        {
            this.type = type;
            this.amount = amount;
            this.years = years;
        }
        public decimal Calculate()
        {
            decimal result = 0;
            decimal discount = DiscountCalculator.CalculatedDiscount(years);
            if (type == CustomerType.unregistered)
            {
                result = amount;
            }
            else if (type == CustomerType.valuable)
            {
                result = ValuableCustomers.CalculatedDiscount(amount, discount);
            }
            else if (type == CustomerType.registered || type == CustomerType.most_valuable)
            {
                result = MostValRegCustomers.CalculatedDiscount(type, amount, discount);
            }
            return result;
        }
    }
}
