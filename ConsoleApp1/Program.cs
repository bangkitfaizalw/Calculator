using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //var b = 6;

            Console.Write("inputkan nilai A");
            int a = int.Parse(Console.ReadLine());

            Console.Write("inputkan nilai B = ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.Title = "Aplikasi Calculator Versi Console";
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " , Penambahan(a, b));

        

            Console.WriteLine("\nTekan sembarangan key untuk keluar");
            Console.ReadKey();


        }
        class Hitung
    {
        public void Main(string[]args)
        {
        }
        public int Penambahan(int a, int b)
        {
            return a + b;
        }
        public int Pengurangan(int a, int b)
        {
            return a - b;
        }
        public int Perkalian(int a, int b)
        {
            return a * b;
        
        }
        public int Pembagian(int a, int b)
        {
            return a / b;
        }
        
    }

   
    }
}
