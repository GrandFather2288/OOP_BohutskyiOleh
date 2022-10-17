using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class DateModifier
    {
        #region Methods

        public static void Difference()
        {
            Console.Write("First year: ");
            int fYear = int.Parse(Console.ReadLine());
            Console.Write("First month: ");
            int fMonth = int.Parse(Console.ReadLine());
            Console.Write("First day: ");
            int fDay = int.Parse(Console.ReadLine());

            DateTime firstDate = new DateTime(fYear, fMonth, fDay);

            Console.Write("Second year: ");
            int sYear = int.Parse(Console.ReadLine());
            Console.Write("Second month: ");
            int sMonth = int.Parse(Console.ReadLine());
            Console.Write("Second day: ");
            int sDay = int.Parse(Console.ReadLine());

            DateTime secondDate = new DateTime(sYear, sMonth, sDay);

            Console.WriteLine();
            double total = (firstDate - secondDate).TotalDays;
            Console.WriteLine("Total days: " + total);
        }

        #endregion
    }
}
