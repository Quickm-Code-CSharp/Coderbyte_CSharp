using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Medium_Challenges
{
    //class Node
    //{
    //    public int value;
    //    public Node left;
    //    public Node right;
    //}

    class TreeGraphs
    {
        public string TreeConstructor(string[] strArr, int length)
        {
            string                              result          = String.Empty;

            bool                                validTree       = true;
            List<string>                        input           = strArr.ToList<string>();
            List<KeyValuePair<int, int>>        data            = new List<KeyValuePair<int, int>>();
            Dictionary<int, List<int>>          parents         = new Dictionary<int, List<int>>();
            Dictionary<int, int>                childCount      = new Dictionary<int, int>();
            int                                 root            = 0;

            data = ParseInput(input);

            foreach(var item in data)
            {
                int key = item.Key;

                // parents[item.first] = item.second;
                // Key Exists - add to list
                if (!parents.TryGetValue(key, out List<int> valueList))
                {
                    valueList = new List<int>();
                    parents.Add(key, valueList);
                }
                valueList.Add(item.Value);

                if (childCount.ContainsKey(item.Value))
                {
                    childCount[item.Value]++;
                }

                else
                {
                    childCount.Add(item.Value, 1);
                }
            }

            // find root
            foreach (var item in data)
            {
                if (parents.ContainsKey(item.Value))
                {
                    root = item.Value;
                }
            }

            validTree = (root != 0);

            // check for > 2 children
            foreach (var item in childCount)
            {
                if (item.Value > 2)
                {
                    validTree = false;
                }
            }

            // check for child with multiple parents
            foreach (var item in parents)
            {
                // Check if List is count > 1
                if (item.Value.Count > 1)
                {
                    validTree = false;
                    break;
                }
            }

            result = (validTree) ? "true" : "false";

            return result;
        }

        protected List<KeyValuePair<int, int>> ParseInput(List<string> input)
        {
            List<KeyValuePair<int, int>> data = new List<KeyValuePair<int, int>>();

            // parse input into data vector
            foreach(string str in input)
            {
                int                     num1 = 0;
                int                     num2 = 0;
                KeyValuePair<int, int>  dataItem;

                ParseInputString(str, ref num1, ref num2);
                dataItem = new KeyValuePair<int, int>(num1, num2);
                data.Add(dataItem);
            }

            return data;
        }

        protected void ParseInputString(string str, ref int num1, ref int num2)
        {
            // assume correct structure
            // find comma -> substr-> trim '('
            // substr rest of str -> trim ')'

            int pos;
            string delimiter = new string(',', 1);
            string temp;

            // extract first number
            pos = str.IndexOf(delimiter);
            if (pos != -1)
            {
                // remove ( char
                temp = str.Substring(pos-1, 1);

                try
                {
                    num1 = Int32.Parse(temp);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Unable to parse {0}", temp);
                    Console.Error.Write(e.Message);
                }
            }

            else
            {
                // pos == -1 --> delimiter not found  assumed to exist
            }

            // extract 2nd number
            temp = str.Substring(pos + 1, 1);
            try
            {
                num2 = Int32.Parse(temp);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Unable to parse {0}", temp);
                Console.Error.Write(e.Message);
            }
        }
    }
}
