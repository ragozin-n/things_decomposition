using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var containersCount = 0;
            Console.WriteLine("Введите кол-во контейнеров");
            try
            {
                containersCount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Неверно задано число");
                containersCount = int.Parse(Console.ReadLine());
            }
            var elements = new List<double>();
            var containers = new List<double>();
            var rnd = new Random();
            for (var i = 0; i < 10000; i++)
            {
                elements.Add(rnd.NextDouble());
            }
            foreach (var element in elements)
            {
                 var max = containers.FindAll(m => m + element <= 1).ToArray();

                if (max.Length > 0)
                {
                    containers[containers.FindIndex(x => Equals(x, max.Max()))] += element;
                }
                else
                {
                    containers.Add(element);
                }
            }
            Console.WriteLine(containers.Count <= containersCount ? containers.Count.ToString() : "Недостаточно контейнеров");
        }
    }
}