using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // -----------------Task1-------------
    public class Task1
    {
        public void DisplayMessage()
        {
            Console.WriteLine("'MyClass' class has initialized!");
        }
    }
    // -----------------Task2-------------
    public class Task2
    {
        public void DisplayMessage(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");
        }
    }
    // -----------------Task3-------------
    public class Task3
    {
        public int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
    // -----------------Task4-------------
    public class Task4
    {
        public void SortIntArray(int[] array)
        {
            Array.Sort(array);
            Console.Write("Sorted array: { ");
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("}");
        }
    }
    // -----------------Task5-------------
    public class Task5
    {
        public void CalculateDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            Console.WriteLine($"Difference: {difference.TotalDays} days");
        }
    }
    // -----------------Task6-------------
    public class Task6
    {
        public void ConvertStringToDate(string dateString)
        {
            DateTime convertedDate = DateTime.Parse(dateString);
            Console.WriteLine($"Converted Date: {convertedDate.ToString("yyyy-MM-dd")}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string dateString = "12-08-2004";
            Task6 converter = new Task6();
            converter.ConvertStringToDate(dateString);
        }
    }

}
