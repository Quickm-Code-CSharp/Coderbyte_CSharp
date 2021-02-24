using System;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class QuestionMarkSum
    {
        // Have the function QuestionsMarks(str) take the str string parameter, which 
        // will contain single digit numbers, letters, and question marks, and check 
        // if there are exactly 3 question marks between every pair of two numbers 
        // that add up to 10. If so, then your program should return the string true, 
        // otherwise it should return the string false.If there aren't any two numbers 
        // that add up to 10 in the string, then your program should return false as well.

        // For example : if str is "arrb6???4xxbl5???eee5" then your program should return 
        // true because there are exactly 3 question marks between 6 and 4, and 3 question 
        // marks between 5 and 5 at the end of the string.
        public string QuestionsMarks(string str)
        {
            string result    = String.Empty;
            bool   pass      = false;
            int    firstPos  = -1;
            int    secondPos = -1;
            int    index     = 0;

            while (index < str.Length)
            {
                if (FindNumbersInString(str, index, out firstPos, out secondPos))
                {

                    int first  = (int)Char.GetNumericValue(str[firstPos]);
                    int second = (int)Char.GetNumericValue(str[secondPos]);


                    // 2 integers must equal 10
                    if ((first + second) == 10)
                    {
                        // There must be exactly 3 question marks between 2 integers
                        pass = IsQuestionMarksExist(str, firstPos, secondPos);
                    }

                    index = secondPos + 1;
                }

                // No numbers found in string
                else
                {
                    pass = false;
                    break;
                }
            }

            result = pass ? "true" : "false";

            return result;
        }

        protected bool FindNumbersInString(string str, int start, out int first, out int second)
        {
            bool    result = false;
                    first = -1;
                    second = -1;

            if (start == str.Length - 1)
            {
                return false;
            }

            for (int index = start; index < str.Length; index++)
            {
                if (Char.IsDigit(str[index]))
                {
                    if (first == -1)
                    {
                        first = index;
                    }

                    else
                    {
                        second = index;
                        break;
                    }
                }
            }

            result = (first != -1 && second != -1);

            return result;
        }

        protected  bool IsQuestionMarksExist(string str, int start, int end)
        {
            bool result = false;

            int num1  = start + 1;
            int num2  = end;
            int count = 0;

            if (num2 - num1 >= 3)
            {
                for (int index = num1; index < num2; index++)
                {
                    if (str[index] == '?')
                    {
                        count++;
                    }
                }

                result = (count == 3);
            }


            return result;
        }
    }
}
