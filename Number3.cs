using System;

namespace CodingChalengeClh
{
    class Number3
    {
        public static void Answer()
        {
          // string s = "abca";
          //  string s = "aba";
           string  s = "abc";
            string newstring = "";

            if (FindPalindrome(s))
            {
                Console.WriteLine("true");
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                newstring = s.Remove(i,1);

                if (FindPalindrome(newstring))
                {
                    Console.WriteLine("true");
                    return;
                }
            }
            Console.WriteLine("false");
          
        }
        public static bool FindPalindrome(string s)
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] == s[s.Length- 1 -i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}