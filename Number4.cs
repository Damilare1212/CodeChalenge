using System;

namespace CodingChalengeClh
{
    class Number4
    {
        public static void Answer()
        {
                int[] nums = {1,12,-5,-6,50,3};
              //  int[] nums = {5};
                int sum = 0;
                float max = 0;
                int k = 4;
 
                for (int i = 0; i <= nums.Length-k; i ++)
                {
                    sum = 0;
                    for(int j =i; j < k+i; j++)
                    {
                        Console.WriteLine($"{nums[j]} ");
                        sum+=nums[j];    
                    }
                    if (sum > max)
                    {
                        max = sum;
                    
                    }
                }
                Console.WriteLine($"  max   {max}  ");
                Console.WriteLine((max/k).ToString("0.00000"));
             // Console.WriteLine(max/k);
               
        }
    }
}