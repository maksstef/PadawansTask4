using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentException();
            }
            else if (str == "")
            {
                throw new ArgumentNullException();
            }
            else
            {
                // put your code here
                int count = 0;
                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
