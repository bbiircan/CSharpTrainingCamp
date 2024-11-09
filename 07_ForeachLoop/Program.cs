using System;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu

            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "istanbul", "bursa" };

            //foreach(string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {45, 34, 38, 16, 13, 26, 9, 3, 18, 2021, 2001 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 34, 38, 16, 13, 26, 9, 3, 18, 2021, 2001 };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 34, 38, 16, 13, 26, 9, 3, 18, 2021, 2001 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total+= i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "hello";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion

            #region Ornek Sinav Sistemi Uygulamasi

            Console.Write("***** C# Egitim Kampi Sinav Uygulamasi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Siniftaki ogrenci sayisini kullanicidan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Ogrenci isimlerini ve not ortalamalarini saklayan diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResults = 0;

                //Her ogrenci icin 3 sinav notu girisi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResults += value; //notları topluyoruz
                }

                Console.WriteLine();

                studentExamAvg[i] = totalExamResults / 3;

            }

            //Sinav Ortalamalari
            for(int i = 0; i<studentCount; i++)
            {
                Console.WriteLine("--------------------------------------");

                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                // Ogrencilerin ortalamasi ve gecip kalma durumlari

                if (studentExamAvg[i] >= 50) 
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
                }

                Console.WriteLine("--------------------------------------");

            }
            #endregion
            Console.ReadKey();

        }
    }
}
