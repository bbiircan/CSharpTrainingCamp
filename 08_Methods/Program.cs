using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Deger Dondurmeyen Metotlar
            //Customer-> listele, ekle, guncelle, sil
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Betül Avcı");
            //    Console.WriteLine("Eylül Ada Bircan");
            //    Console.WriteLine("Rümeysa Bircan");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1999;
            //    int y = 2001;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Deger Dondurmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Rümeysa Bircan");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Rümeysa", "Bircan");
            //CustomerCard("Eylül Ada", "Bircan");


            #endregion

            #region Geriye Deger Dondurmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(3, 9, 1);

            #endregion

            #region Geriye Deger Donduren Metotlar

            //string CustomerName()
            //{
            //    return "Rümeysa Bircan";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Rümeysa";
            //    string surname = "Bircan";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye Deger Donduren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke= "  + countryName + " || Başkent= " + capital + " || Bayrak Rengi= " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz:  ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("İskoçya", "Edinburgh", "Mavi Beyaz"));

            #endregion

            #region Geriye Deger Donduren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(26, 9));
            //Console.WriteLine(Sum(3, 9));
            //Console.WriteLine(Sum(18, 11));
            //Console.WriteLine(Sum(99, 1));
            //Console.WriteLine(Sum(13, 2));

            #endregion

            #region Ornek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3) 
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return student + " isimli öğrenci dersten geçti " + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci dersten kaldı " + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Rümeysa", 80, 95, 85));
            Console.WriteLine(ExamResult("Betül", 100, 100, 100));

            #endregion

            Console.Read();
        }
    }
}
