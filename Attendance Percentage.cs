using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int totalLectures, attendedLectures;

            
            Console.Write("Enter the total number of lectures: ");
            totalLectures = int.Parse(Console.ReadLine());

            
            Console.Write("Enter the number of lectures attended: ");
            attendedLectures = int.Parse(Console.ReadLine());

           
            if (totalLectures <= 0 || attendedLectures < 0 || attendedLectures > totalLectures)
            {
                Console.WriteLine("Invalid input. Please make sure the total lectures are greater than zero, and the attended lectures are within a valid range.");
            }
            else
            {
               
                double attendancePercentage = ((double)attendedLectures / totalLectures) * 100;

               
                Console.WriteLine($"Your attendance percentage is: {attendancePercentage}%");
            }
        }
    }
}
