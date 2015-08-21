using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            funtion input = new funtion();
            input.Input();
            
        }
    }
    class funtion
    {
        
       public void Input()
        {
            string num;
            int[] input;
            Console.WriteLine("Input Number :");
            num = Console.ReadLine();
            input = num.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            
            Process(input);
           
        }

        public void Process(int[]input)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            Output(input);
        }

        public void Output(int[]input)
        {
            Console.WriteLine("Output Number");
            for (int i = 0; i != input.Length; i++)
            {
                
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
