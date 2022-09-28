using System;

namespace Tip_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // İmplict Conversion
           byte a=5;
           sbyte b=30;
           short c=10;
           int d =a+b+c;

           Console.WriteLine("d:"+ d);

            long h=d;
            Console.WriteLine("h:"+h);

            float i =h;
            Console.WriteLine("i:"+i);

            string e ="Onur";
            char f ='P';
            object g = e+f+d;
            Console.WriteLine("g: "+g);
        // Explict Conversion
        int x=4;
        byte y=(byte)x;
        Console.WriteLine("y:"+y);
        int z=300;
        byte t=(byte)z;
        Console.WriteLine("t:"+t);

        //ToString Metodu
        int xx=6;
        string yy=xx.ToString();
        Console.WriteLine("yy:"+yy);

        //System.Convert
        string s1="10",s2="20";
        int say1,say2;
        int Toplam;
        say1=Convert.ToInt32(s1);
        say2=Convert.ToInt32(s2);
        Toplam=say1+say2;
        Console.WriteLine("Toplam: "+Toplam);

        //Parse
        ParseMethod();

        }
        public static void ParseMethod(){
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin1);
            Console.WriteLine("rakam1: "+rakam1);
            double1=Double.Parse(metin2);
            Console.WriteLine("Double: "+double1);
        }
    }
}