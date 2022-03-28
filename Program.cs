using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Mantıksal Operatörleri ***");
            // Atama vs işlemli Atama
            int x = 3;
            int y = 4;

            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 4;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("*** Mantıksal Operatörleri ***");
            // Mantıksal Operatörler
            // "||, &&, !"

            bool isSuccess = true;
            bool isCompleted = false;

            // "ve" operatoru, calismasi icin ikiside dogru olmasi gerekir
            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            // "veya" operatoru, calismasi icin birinin dogru olmasi
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            // "olma" "not" operatoru, calismasi icin ikisininde yanlis olmasi gerekir
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            Console.WriteLine("*** İlişkisel Operatörleri ***");
            // İlişkisel Operatörler
            // "<, >, <=, >=, ==, !="

            int kucuk = 3;
            int buyuk = 4;
            bool sonuc = kucuk < buyuk;

            Console.WriteLine(sonuc);
            sonuc = kucuk > buyuk;
            Console.WriteLine(sonuc);
            sonuc = kucuk >= buyuk;
            Console.WriteLine(sonuc);
            sonuc = kucuk <= buyuk;
            Console.WriteLine(sonuc);
            sonuc = kucuk == buyuk;
            Console.WriteLine(sonuc);
            sonuc = kucuk != buyuk;
            Console.WriteLine(sonuc);

            Console.WriteLine("*** Aritmetik Operatörler ***");
            // + , - , * , /

            int sayi1 = 10;
            int sayi2 = 5;
            
            int toplamSonuc = sayi1 + sayi2;
            Console.WriteLine(toplamSonuc);
            
            int cikarmaSonuc = sayi1 - sayi2;
            Console.WriteLine(cikarmaSonuc);
            
            int carpimSonuc = sayi1 * sayi2;
            Console.WriteLine(carpimSonuc);

            int bolumSonuc = sayi1 / sayi2;
            Console.WriteLine(bolumSonuc);

            // kalan hesabı: % (mod)

            int kalanHesabi = carpimSonuc % 4;
            Console.WriteLine(kalanHesabi);

            // increment operator
            Console.WriteLine("Increment Operator");
            // x++ operasyondan onceki degeri
            Console.WriteLine(sayi1++); // deger 11 oldu fakat konsol 10 gosterecek

            //++x operasyong sonraki degeri
            Console.WriteLine(++sayi1); // konsol 12 gosterecek
        }
    }
}
