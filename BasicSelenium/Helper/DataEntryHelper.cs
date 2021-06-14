using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSelenium.Helper
{
    public static class DataEntryHelper
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N").ToUpper().Substring(1,10);
        }

        public static int GenerateNumber(int maxNumber = 100)
        {
            return new Random().Next(1, maxNumber);
        }
    }
}
