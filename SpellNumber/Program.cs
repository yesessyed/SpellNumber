using System;


namespace SpellNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumbertoWords = ClassLibrarySpellNumber.SpellNumber.NumberToWords(100000);

            Console.WriteLine("Check for Spell Number");
            Console.WriteLine("Rs: {0} ", NumbertoWords);
            Console.ReadLine();
        }

    }
}
