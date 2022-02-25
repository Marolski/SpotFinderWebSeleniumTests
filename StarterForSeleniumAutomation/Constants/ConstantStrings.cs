using SpotFinderWebSeleniumTests.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotFinderWebSeleniumTests.Constants
{
    public class ConstantStrings
    {
        public static string CONNECTION_STRING = "";

        public static string GetUrl()
        {
            //Sets the URL based on which environment is set in the ConstantTestProperties.cs
            if (TestEnvironment.Prod == ConstantTestProperties.ENVIRONMENT)
                return "https://splendorwrld.com/";
            else
                throw new NotImplementedException();
        }
    }
}
