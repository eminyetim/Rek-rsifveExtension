using System;

namespace RekürsifandExtension
{
    class program
    {
        public static void Main(string[] args)
        {
            int res = 1;
            for (int i = 1; i <5; i++)
            {
                res = res * 3;
            }

            System.Console.WriteLine(res);

            Islemler instance = new();
            System.Console.WriteLine(instance.Expo(3,4));

            string ifade = "Muhammed Emin Yetim";
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine(sonuc);
            
            if(sonuc)
            {
               System.Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            System.Console.WriteLine(ifade.RemoveWhiteSpaces().BuyukHarf());
            System.Console.WriteLine(ifade.RemoveWhiteSpaces().KucukHarf());

            int[] dizi = {5 , 4 , 2 , 8 , 12};
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item);
            }

            int a = 5;
            System.Console.WriteLine( a.CiftMi() );

            string strMy = "kalem";
            System.Console.WriteLine(strMy.ilkKarakter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi , int üs)
        {
            if(üs <= 1)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;

        }
    }  


    //class static olursa nesne oluşturmadan erişebiliriz.

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string BuyukHarf(this string str)
        {
            return str.ToUpper();
        }

        public static string KucukHarf(this string str)
        {
            return str.ToLower(); 
        }

        public static int[] diziSırala(this int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static int[] indiziYaz(this int[] arr)
        {
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
            return arr;
        }

        public static bool CiftMi(this int sayi)
        {
            return (sayi % 2 == 0);
        }

        public static char ilkKarakter(this string str)
        {
            return str[0];
        }
    }

}