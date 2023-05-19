using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dien can nang cua ban");
            double height = float.Parse(Console.ReadLine());
            Console.WriteLine("Dien chieu cao cua ban");
            double weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2); 
            //Math.Pow de ^2 mot so
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine("Thieu can");
            else if (bmi < 25.0)
                Console.WriteLine("Binh thuong");
            else if (bmi < 30.0)
                Console.WriteLine("Thua can");
            else
                Console.WriteLine("Beo phi");
        }
    }
}
