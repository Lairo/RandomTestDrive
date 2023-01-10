using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTestDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);
            Console.WriteLine((float)randomDouble * 100F);
            Console.WriteLine((decimal)randomDouble * 100M);

            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);


            string[] randomStrings = new string[] {"1. peppe", "2. kappa", "3. smiley", "4. Giga-chad", "5. pepe-chad", "6. Dwight" };
            int randomIndex = random.Next(randomStrings.Length);
            string randomString = randomStrings[randomIndex];
            Console.WriteLine(randomString);

        }
    }
}
