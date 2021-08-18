using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class UserProgramCode
    {
        public static int diffIntArray(int[] input1)
        {
            int diff = 0;

            for(int i = 0; i < input1.Length; i++)
            {
                for(int j = i + 1; j < input1.Length; j++)
                {
                    if ((input1[i] < input1[j]) && (input1[j] - input1[i]) > diff)
                    {
                        
                            diff = input1[j] - input1[i];
                        
                    }
                }
            }

            return diff;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());

            int[] input1 = new int[n];

            Console.WriteLine("Enter the elements");

            for(int i = 0; i < n; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
            }


            int w = UserProgramCode.diffIntArray(input1);
            Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
