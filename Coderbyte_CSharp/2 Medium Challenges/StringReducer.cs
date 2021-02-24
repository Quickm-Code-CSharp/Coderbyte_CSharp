using System;
using System.Text;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class StringReducer
    {
        // For this challenge you will manipulate a string of characters using a simple 
        // reduction method.

        // The function StringReduction(str) take the str parameter being passed and 
        // return the smallest number you can get through the following reduction 
        // method. The method is: Only the letters a, b, and c will be given in str and 
        // you must take two different adjacent characters and replace it with the third. 

        // For example "ac" can be replaced with "b" but "aa" cannot be replaced with 
        // anything. This method is done repeatedly until the string cannot be further 
        // reduced, and the length of the resulting string is to be outputted. 

        // For example: if str is "cab", "ca" can be reduced to "b" and you get "bb" (you 
        // can also reduce it to "cc"). The reduction is done so the output should be 2. 
        // If str is "bcab", "bc" reduces to "a", so you have "aab", then "ab" reduces to 
        // "c", and the final string "ac" is reduced to "b" so the output should be 1. 
        public int StringReduction(string str)
        {
            int     result      = 0;
            string  localStr    = str;
            int     length      = str.Length;
            bool    done        = false;

            if (length == 1)
            {
                result = 1;
            }

            else if (length == 2)
            {
                string temp = ConvertChar(str[0], str[1]);
                result = temp.Length;
            }

            else
            {
                while (!done)
                {
                    string temp;

                    //cout << "Reduction: " << localStr;
                    for (int index = 0; index < localStr.Length - 1 && !done; index++)
                    {
                        temp = ConvertChar(localStr[index], localStr[index + 1]);

                        // remove chars
                        localStr = localStr.Remove(index, 2);

                        // replace chars
                        localStr = localStr.Insert(index, temp);
                        
                        //cout << " --> " << localStr;

                        // check if end criteria met
                        done = IsDone(localStr);
                    }

                    //cout << endl;

                    if (done)
                    {
                        result = localStr.Length;
                    }

                    else
                    {
                        //cout << "Need another iteration" << endl;
                    }
                }
            }

            return result;
        }

        protected string ConvertChar(char first, char second)
        {
            string result = String.Empty;

            if (first == second)
            {
                StringBuilder sb = new StringBuilder(); 

                sb.Append(first);
                sb.Append(second);

                result = sb.ToString();
            }

            else
            {
                if ((first == 'a' && second == 'b') ||
                    (first == 'b' && second == 'a'))
                {
                    result = "c";
                }

                else if ((first == 'a' && second == 'c') ||
                         (first == 'c' && second == 'a'))
                {
                    result = "b";
                }

                else if ((first == 'b' && second == 'c') ||
                    (first == 'c' && second == 'b'))
                {
                    result = "a";
                }
            }

            return result;
        }

        protected bool IsDone(string str)
        {
            bool done = false;

            int length = str.Length;

            if (length == 1)
            {
                done = true;
            }

            else
            {
                done = true;
                char checkchar = str[0];

                for (int index = 1; index < length && done; index++)
                {
                    done = (checkchar == str[index]);
                }
            }

            return done;
        }
    }
}
