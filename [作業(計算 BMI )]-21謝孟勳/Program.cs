using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_計算_BMI____21謝孟勳
{
    //計算 BMI
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的身高: ");
            string height = Console.ReadLine();

            Console.WriteLine("請輸入你的體重: ");
            string weight = Console.ReadLine();

            Double BMI = double.Parse(weight) / ((double.Parse(height )/100) * ((double.Parse(height) /100)));
            
            Console.WriteLine($"您的BMI是: {Math.Round(BMI,1)}");

        }
    }
}
