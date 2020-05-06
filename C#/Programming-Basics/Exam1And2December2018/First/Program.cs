using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var alpinisti = int.Parse(Console.ReadLine());
            var karabineri = int.Parse(Console.ReadLine());
            var vujeta = int.Parse(Console.ReadLine());
            var pikeli = int.Parse(Console.ReadLine());

            decimal karabineriSum = karabineri * 36;
            decimal vujetaSum = vujeta * 3.60m;
            decimal pikeliSum = pikeli * 19.80m;
            decimal sumForOneAlpinist = karabineriSum + pikeliSum + vujetaSum;
            decimal sumForAll = sumForOneAlpinist * alpinisti;
            decimal sumWithDDC = sumForAll + (sumForAll * 0.20m);
            Console.WriteLine(Math.Round(sumWithDDC, 2));
        }
    }
}
