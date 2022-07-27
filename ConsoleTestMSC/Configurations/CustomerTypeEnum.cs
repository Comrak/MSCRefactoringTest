using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestMSC.Configurations
{
    //this enum was create to avoid the instantiation of any type of customer that its no considered into the firts development of the procces
    public enum CustomerType
    {
        unregistered = 1,
        registered = 2,
        valuable = 3,
        most_valuable = 4
    }

}
