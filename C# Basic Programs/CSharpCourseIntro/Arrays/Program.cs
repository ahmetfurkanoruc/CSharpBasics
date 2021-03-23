using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students2 = { "Engin", "Derin", "Salih" };

            //foreach(var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[7, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Mersin","Adana"},
                {"Rize","Samsun","Ordu"},
                {"İzmir","Muğla","Manisa"},
                {"Şanlıurfa","Gaziantep","Mardin"},
                {"Kars","Ağrı","Erzurum" }
            };

            for(int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("--------------");
            }

            //Console.WriteLine();
            Console.ReadLine();

        }
    }
}
