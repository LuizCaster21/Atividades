using System;
using System.Globalization;

namespace Atv
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt1 = DateTime.ParseExact("2008-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact("15/08/2008 13:45:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            }
    }
}   