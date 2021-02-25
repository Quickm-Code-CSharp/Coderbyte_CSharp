using System;

namespace Coderbyte_CSharp._1_Easy_Challenges
{
    class UsernameValidation
    {
        //Have the function CodelandUsernameValidation(str) take the str parameter being
        //    passed and determine if the string is a valid username according to the
        //following rules :

        //1. The username is between 4 and 25 characters.
        //2. It must start with a letter.
        //3. It can only contain letters, numbers, and the underscore character.
        //4. It cannot end with an underscore character.

        //If the username is valid then your program should return the string true,
        //otherwise return the string false.

        public string CodelandUsernameValidation(string str)
        {
            string result = String.Empty;

            bool rule1 = ValidateLength(str);
            bool rule2 = ValidateStartWithLetter(str);
            bool rule3 = ValidateOnlyValidCharacters(str);
            bool rule4 = ValidateEndCharacter(str);

            result = (rule1 && rule2 && rule3 && rule4) ? "true" : "false";


            return result;
        }

        protected bool ValidateLength(string str)
        {
            bool isValid = false;

            int length = str.Length;

            isValid = (length >= 4 && length <= 25);

            return isValid;
        }

        protected bool ValidateStartWithLetter(string str)
        {
            bool isValid = false;

            isValid = Char.IsLetter(str[0]);

            return isValid;
        }

        protected bool ValidateOnlyValidCharacters(string str)
        {
            bool isValid = true;

            foreach (char c in str)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_')
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        protected bool ValidateEndCharacter(string str)
        {
            bool isValid = false;
            int  length  = str.Length;

            isValid = (str[length - 1] != '_');

            return isValid;
        }


    }
}
