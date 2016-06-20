using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int containersCount, elementsCount;
            string userInput;
            List<double> containers = new List<double>();
            List<double> elements = new List<double>();

            do
            {
                Console.Write("Введите кол-во контейнеров: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out containersCount));

            do
            {
                Console.Write("Введите кол-во элементов: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out elementsCount));

            //Генерируем elementsCount случайных элементов
            for (var i = 0; i < elementsCount; i++)
            {
                elements.Add(new Random().NextDouble());
            }

            foreach (var element in elements)
            {
                //Допустимые контейнеры для element (в которые он влезет)
                double[] max = containers.FindAll(m => m + element <= 1).ToArray();

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
            Console.ReadKey();
        }
    }
}