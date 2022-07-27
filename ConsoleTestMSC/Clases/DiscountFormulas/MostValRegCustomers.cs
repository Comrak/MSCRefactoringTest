using ConsoleTestMSC.Configurations;
using System;

namespace ConsoleTestMSC.Clases.DiscountFormulas
{
    static internal class MostValRegCustomers
    {
        internal static decimal CalculatedDiscount(CustomerType type, decimal amount, decimal disc)
        {
            /*
            this class is handles the calculation of the discount for registered or most valuable customer if any other tipe of customer its inserted 
            the value of the extra discount or constant as refered in the method will be 1 
            its static so it doesnt have to be instanciated to use its methods 
            */

            //getting the constant
            Constant constants = Constant.GetConstant();
            //returning discount result
            decimal constant = ( type == CustomerType.registered ) ? constants.registeredCustomer : (type == CustomerType.most_valuable ? constants.mostValuableCustomer : 1);
            decimal result = (amount - (constant * amount)) - disc * (amount - (constant * amount));
            return result;
        }
    }
}
