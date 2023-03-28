using System;
using System.Collections.Generic;

namespace Coderbyte_CSharp.Hard_Challenges
{
    class Determinant
    {
        // Have the function MatrixDeterminant(strArr) read strArr which will be an 
        // array of integers represented as strings.Within the array there will also 
        // be "<>" elements which represent break points.The array will make up a 
        // matrix where the(number of break points + 1) represents the number of 
        // rows.Here is an example of how strArr may look : ["1", "2", "<>", "3", "4"].
        //
        // The contents of this array are row1 = [1 2] and row2 = [3 4]. Your program 
        // should take the given array of elements, create the proper matrix, and then 
        // calculate the determinant. For the example above, your program should return -2. 
        // If the matrix is not a square matrix, return -1. The maximum size of strArr
        // will be a 6x6 matrix.The determinant will always be an integer.
        public int MatrixDeterminant(string[] strArr, int size)
        {
            int determinant = 0;

            List<List<int>> matrix = new List<List<int>>();

            ParseMatrix(strArr, size, ref matrix);


            if (IsSquareMatrix(matrix))
            {
                determinant = ComputeDeterminant(matrix);
            }

            else
            {
                Console.WriteLine("matrix is not square");
            }

            return determinant;
        }

	    protected   bool    IsSquareMatrix(List<List<int>> matrix)
        {
            bool isSquare = true;

            // checking if input matrix is square
            for (int row = 0; row < matrix.Count; row++)
            {
                if (matrix[row].Count != matrix.Count)
                {
                    isSquare = false;
                    break;
                }
            }

            return isSquare;
        }

        protected   void    ParseMatrix(string[] strArr, int size, ref List<List<int>> matrix)
        {
            List<int> rowData = new List<int>();

            for (int x = 0; x < size; x++)
            {
                // condition to check for breakpoints
                if (strArr[x] == "<>")
                {
                    // Create a separate copy of rowData for matrix
                    matrix.Add(new List<int>(rowData));
                    rowData.Clear();
                }
                else
                {
                    // converting to int
                    int value = 0;
                    
                    // convert to snippet
                    try
                    {
                        value = Int32.Parse(strArr[x]);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Unable to parse {0}", strArr[x]);
                        Console.Error.Write(e.Message);
                    }

                    // adding to our row
                    rowData.Add(value);
                }
            }
            // adding last row
            // Create a separate copy of rowData for matrix
            matrix.Add(new List<int>(rowData));
        }

        protected   int     ComputeDeterminant(List<List<int>> matrix)
        {
            int determinant = 0;

            if (matrix.Count == 1)
            {
                determinant = matrix[0][0];
            }
            // check for 2-by-2 matrix perform det calculation
            else if (matrix.Count == 2)
            {
                determinant = (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
            }

            // otherwise determine cofactor, submatrix and recursively compute determinant
            else
            {
                int cofactor = 0;
                // iterate across first row to set cofactor
                for (int p = 0; p < matrix[0].Count; p++)
                {
                    // create submatrix
                    List<List<int>> subMatrix   = new List<List<int>>();
                    int             matrixSize  = matrix.Count;

                    for (int i = 1; i < matrixSize; i++)
                    {
                        // iteration will start from row one cancelling the first row values
                        List<int> tempRow = new List<int>();

                        for (int j = 0; j < matrixSize; j++)
                        {
                            // iteration will pass all cells of the i row excluding the j 
                            //value that match p column
                            if (j != p)
                            {
                                tempRow.Add(matrix[i][j]);//add current cell to TempRow 
                            }
                        }

                        // Adding each row to submatrix
                        if (tempRow.Count > 0)
                        {
                            subMatrix.Add(tempRow);
                        }
                    }

                    // recursively calculate the determinant value
                    cofactor = matrix[0][p];
                    determinant += (int)(Math.Pow(-1, p)) * cofactor * ComputeDeterminant(subMatrix);
                }
            }

            return determinant;
        }
    }
}
