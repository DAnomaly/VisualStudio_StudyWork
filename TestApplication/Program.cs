using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            var value = new DataTable().Compute("1 / 0.3", "");

            StringBuilder str = new StringBuilder();
            if (value.GetType() == typeof(decimal))
                str.Append(Decimal.Round((decimal)value,3));
            else
                str.Append(value);

            Console.WriteLine(str.ToString());
        }
    }
}
