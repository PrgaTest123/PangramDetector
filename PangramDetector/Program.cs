using System;
using System.Linq;

namespace PangramDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter words: ");
            string str = Console.ReadLine();
            Console.WriteLine(IsPangram(str));
        }

        public static bool IsPangram(string str)
        {
            //You can use Distinct() in exchange for GroupBy()
            return str.ToLower().Where(ch=> Char.IsLetter(ch)).GroupBy(ch=> ch).Count()==26;
        }
    }
}
