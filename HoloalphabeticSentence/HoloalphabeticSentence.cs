using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            int flag=0;
            input=input.ToLower();
            for (int i = 0; i < alphabets.Length; i++)
            {
                if(!(input.Contains(alphabets[i])))
                {
                    flag=1;
                    break;
                }
            }
            if(flag==0)
            {
                return true;
            }
            return false;   
        }
    }
}
