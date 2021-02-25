using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C_sharp_practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }


    }
}
