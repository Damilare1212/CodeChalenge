using System;

namespace CodingChalengeClh
{
    class Number1
    {
        public static void Answer()
        {
          //  int [] arr = {10,2,5,3};
          //  int [] arr = {7,1,14,11};
            int [] arr = {3,0,2,11};
         // int [] arr = {4,6,8,15};
          
         
         int counter = 0;
        // bool check = true;
            for (int i = 0; i<arr.Length-1; i++)
            {
                for (int j = 0; j<arr.Length ; j++)
              {
                    if (arr[i] == arr[j]*2 && i != j )
                    {
                       
                       counter++;
                      //    check = false;
                       break;
                    
                    }
                    
                }
            }
            // if (check)
            // {
            //    Console.WriteLine(check);
            // }
             
           // Console.WriteLine((arr[i] == arr[j]*2 && i != j );
            if (counter>0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            
        }        
    }
}