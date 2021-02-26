using System;
using Coderbyte_CSharp.Easy_Challenges;

namespace Coderbyte_CSharp._3_Hard_Challenges
{
    class ChessBoard
    {
        // Have the function ChessboardTraveling(str) read str which will be a string 
        // consisting of the location of a space on a standard 8x8 chess board with 
        // no pieces on the board along with another space on the chess board. The 
        // structure of str will be the following: "(x y)(a b)" where (x y) represents 
        // the position you are currently on with x and y ranging from 1 to 8 and 
        // (a b) represents some other space on the chess board with a and b also 
        // ranging from 1 to 8 where a > x and b > y. Your program should determine 
        // how many ways there are of traveling from (x y) on the board to (a b) 
        // moving only up and to the right. For example: if str is (1 1)(2 2) then your 
        // program should output 2 because there are only two possible ways to travel 
        // from space (1 1) on a chessboard to space (2 2) while making only moves up 
        // and to the right.
        public int ChessboardTraveling(string str)
        {
            int result = 0;
            int x, y, a, b;
            //char* token = nullptr;
            //char* data = const_cast<char*>(str.c_str());
            //char* next = nullptr;

            //token = strtok_s(data, "( )", &next); x = *token - '0';
            //token = strtok_s(NULL, "( )", &next); y = *token - '0';
            //token = strtok_s(NULL, "( )", &next); a = *token - '0';
            //token = strtok_s(NULL, "( )", &next); b = *token - '0';


            ParseInput(str, out x, out y, out a, out b);

            int row = a - x;
            int col = b - y;

            result = Ckn(row, row + col);

            return result;
        }

        protected void ParseInput(string str, out int x, out int y, out int a, out int b)
        {
            x = y = a = b = 0;

            // remove index = 0, length-1 for outer parentheses
            str = str.Substring(1, str.Length - 2);

            // Get strings for 2 positions
            string[] input = str.Split(")(".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            // 
            string[] starting = input[0].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] ending = input[1].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            
            x = Convert.ToInt32(starting[0]);
            y = Convert.ToInt32(starting[1]);
            a = Convert.ToInt32(ending[0]);
            b = Convert.ToInt32(ending[1]);
        }

        protected  int Ckn(int k, int n)
        {
            int       result    = 0;
            int       c         = 1;

            for (int i = n, j = 0; j < k; i--, j++)
            {
                c *= i;
            }

            Factorial factorial = new Factorial();

            var nFact  = factorial.FirstFactorial(n);
            var nkFact = factorial.FirstFactorial(n-k);
            var kFact  = factorial.FirstFactorial(k);


            result = (int)(nFact / (kFact * nkFact));
            return result;
        }
    }
}
