using ConsoleTestMSC.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestMSC.Interfaces
{
    public interface ICalculator
    {
        //this interface its a contract that assure the any class implementing it will have a Calculate method 
        public decimal Calculate();
    }

}
