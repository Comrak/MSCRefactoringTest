using ConsoleTestMSC.Configurations;

namespace ConsoleTestMSC.Clases.DiscountFormulas
{
    static internal class ValuableCustomers
    {
        internal static decimal CalculatedDiscount(decimal amount, decimal disc)
        {
            /*
             this class handles the calculation of the discount for valuable customers
             its static so it doesnt have to be instanciated to use its methods 
            */

            //getting the constant
            Constant constants = Constant.GetConstant();
            //returning discount result
            decimal result = (constants.valuableCustomer * amount) - disc * (constants.valuableCustomer * amount);
            return result;
        }
    }
}
