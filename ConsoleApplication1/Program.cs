using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"D:\lab2.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(stream);

            string line = reader.ReadToEnd();

            reader.Close();
            stream.Close();

            string[] arr = line.Split(new char[] { ' ', '\n', '\r' });
            int length = arr.Length;
            int max = 0;
            int min = 1000000;

            for (int i = 0; i < length; i++)
            {
                string element = arr[i];
                if (element != "")
                {
                    int value = Int32.Parse(element);

                    
                    if (value < min)
                    {
                        min = value;
                    }
                    else if(value> max)
                    {
                        max = value;
                    }
                }
            }
            Console.WriteLine("the minimum " + min);
            Console.WriteLine("the maximum " + max);
            Console.ReadKey();
        }

        private static bool IsPrime(int value)
        {
            throw new NotImplementedException();
        }
    }
}