using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * string city = "Ankara";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}",city,city2));
            Console.WriteLine("{0} {1}",city, city2);

            */
            string sentence = "Ahmet Furkan Oruç";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "Mustafa Barış Uğur";

            bool result3 = sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("M");

            var result5 = sentence.IndexOf("Barış");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(8);
            var result10 = sentence.Substring(8, 5);
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ", "-");
            var result14 = sentence.Remove(8,6);

            Console.WriteLine(result14);
            Console.ReadLine();
        }
    }
}
