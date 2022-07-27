using ConsoleTestMSC.Clases;
using ConsoleTestMSC.Configurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class MainTesting
    {
        [TestMethod]
        public void DiscountForUnregisteredCustomer()
        {
            Discount disc1 = new Discount(CustomerType.unregistered, 1.5E6m, 2022);

            decimal result1 = disc1.Calculate();
            Assert.AreEqual(Convert.ToDecimal("1500000"), result1);
        }
        [TestMethod]
        public void DiscountForRegisteredCustomer()
        {
            Discount disc2 = new Discount(CustomerType.registered, 1.5E6m, 2022);

            decimal result2 = disc2.Calculate();
            Assert.AreEqual(Convert.ToDecimal("1282500,000"), result2);
        }
        [TestMethod]
        public void DiscountForValuableCustomer()
        {
            Discount disc3 = new Discount(CustomerType.valuable, 1.5E6m, 2022);

            decimal result3 = disc3.Calculate();
            Assert.AreEqual(Convert.ToDecimal("997500,000"), result3);
        }
        [TestMethod]
        public void DiscountForMostValuableCustomer()
        {
            Discount disc4 = new Discount(CustomerType.most_valuable, 1.5E6m, 2022);

            decimal result4 = disc4.Calculate();
            Assert.AreEqual(Convert.ToDecimal("712500,000"), result4);
        }
    }
}
