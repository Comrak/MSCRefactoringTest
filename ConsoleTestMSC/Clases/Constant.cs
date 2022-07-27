using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ConsoleTestMSC.Configurations
{
    internal class Constant
    {
        /*
          this class handles the extraction of constants from the constants xml file to avoid the use of hard code on the process 
          it implemenst the singleton design pattern to avoid multiple instantiations of the same object
        */

        private static Constant constant;
        public decimal registeredCustomer;
        public decimal valuableCustomer;
        public decimal mostValuableCustomer;
        public int maxYears;
        public int percentile;

        private Constant()
        {

        }
        public static Constant GetConstant()
        {
            //if this class was never instantiate we enter here to do the firts initialization
            if (constant == null)
            {
                // Setting the name and type of the constant file 
                string fileName = "constants.xml";
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                //this combines the current project directory with the constant file location to create a valid path 
                string path = Path.Combine(projectDirectory, @"Configurations\", fileName);
                XmlDocument doc = new XmlDocument();
                // this load the document 
                doc.Load(path);
                var item = doc.SelectNodes("//Constant/Value");

                // here we do the firts instantiation of the Constant class and set the values from the constant.xml file 
                constant = new Constant();
                constant.registeredCustomer = Convert.ToDecimal((item.Item(0).FirstChild).InnerText);
                constant.valuableCustomer = Convert.ToDecimal((item.Item(1).FirstChild).InnerText);
                constant.mostValuableCustomer = Convert.ToDecimal((item.Item(2).FirstChild).InnerText);
                constant.maxYears = Convert.ToInt32((item.Item(3).FirstChild).InnerText);
                constant.percentile = Convert.ToInt32((item.Item(4).FirstChild).InnerText);

                // before returning the constant object we force the closing of the doc and item object and calla the garbage collector to frees the use resources
                doc = null;
                item = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return constant;
            }
            // if this class was instantiate we just return the already create object
            return constant;
           
        }
    }
}
