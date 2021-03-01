using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;

namespace Coderbyte_CSharp.Medium_Challenges
{
    class Node 
    {
        public string Key;
        public Node Left;
        public Node Right;

        public Node(string item)
        {
            Key   = item;
            Left  = null;
            Right = null;
        }

    }

    class TreeGraphs
    {
        public string TreeConstructor(string[] strArr, int length)
        {
            string result = String.Empty;

            bool validTree = true;
            List<string> input = strArr.ToList();
            List<KeyValuePair<int, int>> data = new List<KeyValuePair<int, int>>();
            Dictionary<int, List<int>> parents = new Dictionary<int, List<int>>();
            Dictionary<int, int> childCount = new Dictionary<int, int>();
            int root = 0;

            data = ParseInput(input);

            foreach (var item in data)
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

        // For this challenge you will traverse a binary tree and determine if it is symmetric.
        // The function SymmetricTree(strArr) take the array of strings stored in strArr, 
        // which will represent a binary tree, and determine if the tree is symmetric (a 
        // mirror image of itself). The array will be implemented similar to how a binary 
        // heap is implemented, except the tree may not be complete and NULL nodes on any 
        // level of the tree will be represented with a #. 

        // For example: if strArr is ["1", "2", "2", "3", "#", "#", "3"]
        // Tree:
        //				1
        //		2				2
        //	3		#		#		3

        // For the input above, your program should return the string true because the 
        // binary tree is symmetric.

        public string SymmetricTree(string[] strArr, int length)
        {
            string result = String.Empty;
            bool isSymmetric = false;
            List<string> input = new List<string>(strArr);

            Node root = CreateTreeNode(input[0]);

            //populate tree
            root = FillTree(input, root, 0, input.Count);

            // check for symmetry
            isSymmetric = IsTreeSymmetric(root, root);


            result = (isSymmetric) ? "true" : "false";




            return result;
        }

        private Node FillTree(List<string> arr, Node root, int index, int length)
        {
            if (index < length)
            {
                Node temp = CreateTreeNode(arr[index]);
                root = temp;

                // insert left child 
                root.Left = FillTree(arr, root.Left, 2 * index + 1, length);

                // insert right child 
                root.Right = FillTree(arr, root.Right, 2 * index + 2, length);
            }

            return root;
        }


        protected List<KeyValuePair<int, int>> ParseInput(List<string> input)
        {
            List<KeyValuePair<int, int>> data = new List<KeyValuePair<int, int>>();

            // parse input into data vector
            foreach (string str in input)
            {
                int num1 = 0;
                int num2 = 0;
                KeyValuePair<int, int> dataItem;

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
            pos = str.IndexOf(delimiter, StringComparison.Ordinal);
            if (pos != -1)
            {
                // remove ( char
                temp = str.Substring(pos - 1, 1);

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

        protected Func<string, Node> CreateTreeNode = value => new Node(value);

        protected bool IsTreeSymmetric(Node node1, Node node2)
        {
        bool isSymmetric = false;

            // empty tree
            if (node1 == null && node2 == null)
            {
                isSymmetric = true;
            }

            // For two trees to be mirror 
            // images, the following
            // three conditions must be true 
            // 1 - Their root node's data must be same 
            // 2 - left subtree of left tree and right subtree of right tree are equal
            // 3 - right subtree of left tree and left subtree of right tree are equal
            else if (node1 != null && node2 != null && node1.Key == node2.Key)
            {
                isSymmetric = IsTreeSymmetric(node1.Left, node2.Right) &&
                              IsTreeSymmetric(node1.Right, node2.Left);
            }
            return isSymmetric;
        }
    }
}
