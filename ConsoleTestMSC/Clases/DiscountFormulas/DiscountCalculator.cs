using ConsoleTestMSC.Configurations;
using System;

namespace ConsoleTestMSC.Clases.DiscountFormulas
{
    static internal class DiscountCalculator
    {
        /*
         this class is in charge of calculate the main discount according to the amount of years of each customer regarding their type
         its static so it doesnt have to be instanciated to use its methods 
        */
        static public decimal Discount { get; set; }

        internal static decimal CalculatedDiscount(int years)
        {
            //getting the constant
            Constant constants = Constant.GetConstant();
            //using the min method this returns the lesser of the operators
            //if years is less than 5 this will always return 0,05, else will return the amount of years divided by 100
            Discount = Math.Min(((decimal)constants.maxYears / constants.percentile),((decimal)years / constants.percentile));
            //returning discount result
            return Discount;
        }
    }
}
