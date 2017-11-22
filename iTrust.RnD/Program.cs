using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTrust.RnD
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
               string test = Guid.NewGuid().ToString("N").ToUpper();
                Console.WriteLine("test: " + test);
                string word = Console.ReadLine();
                bool result = Utility.isAnEnglishWord(word);
                Console.WriteLine("Result is: " + result);
                Console.ReadKey();
            }
           

        }
    }
}
