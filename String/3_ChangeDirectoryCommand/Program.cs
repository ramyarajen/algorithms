using System;
using System.Collections.Generic;
using System.Text;

namespace _2_StringToBinary
{
    public class StringUtil
    {
        public static IDictionary<string, int> ChangeDirectoryVisit(string cdStr)
        {
            if (String.IsNullOrWhiteSpace(cdStr))
            {
                Console.WriteLine("\nInput String: {0}", cdStr);
                Console.WriteLine("Input String is empty");
                return null;
            }

            IDictionary<string, int> countMap = new Dictionary<string, int>();
            string[] pathSplit = cdStr.Split('\\');
            Stack<string> pathStack = new Stack<string>();

            foreach (string path in pathSplit)
            {
                if (path != ".." && path != ".")
                {
                    pathStack.Push(path);
                    if (!countMap.ContainsKey(path))
                    {
                        countMap.Add(new KeyValuePair<string, int>(path, 0));
                    }
                    countMap[path]++;
                }
                else if (path == ".")
                {
                    //. means in the current directory
                    if (pathStack.Count > 0)
                    {
                        string currentPathInStack = pathStack.Peek();
                        countMap[currentPathInStack]++;
                    }
                    else
                    {
                        Console.WriteLine("\nInput String: {0}", cdStr);
                        Console.WriteLine("Input String is malformed - Path went before root");
                        return null;
                    }
                }
                else if (path == "..")
                {
                    //.. means going to parent directory
                    if (pathStack.Count > 0)
                    {
                        pathStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("\nInput String: {0}", cdStr);
                        Console.WriteLine("Input String is malformed - Path went before root");
                        return null;
                    }

                    if (pathStack.Count > 0)
                    {
                        string currentPathInStack = pathStack.Peek();
                        countMap[currentPathInStack]++;
                    }
                    else
                    {
                        Console.WriteLine("\nInput String: {0}", cdStr);
                        Console.WriteLine("Input String is malformed - Path went before root");
                        return null;
                    }
                }
            }

            Console.WriteLine("\nInput String: {0}", cdStr);
            foreach (string path in countMap.Keys)
            {
                Console.WriteLine("{0} <=> {1}", path, countMap[path]);
            }

            return countMap;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "";
            StringUtil.ChangeDirectoryVisit(input1);

            string input2 = "a\\b\\c";
            StringUtil.ChangeDirectoryVisit(input2);

            string input3 = "a\\b\\c\\..";
            StringUtil.ChangeDirectoryVisit(input3);

            string input4 = "a\\b\\c\\..\\..";
            StringUtil.ChangeDirectoryVisit(input4);

            string input5 = "a\\b\\c\\..\\..\\b\\c";
            StringUtil.ChangeDirectoryVisit(input5);

            string input6 = "a\\b\\c\\..\\..\\b\\d";
            StringUtil.ChangeDirectoryVisit(input6);

            string input7 = "a\\b\\.\\.\\c";
            StringUtil.ChangeDirectoryVisit(input7);

            //Invalid Paths - Gone above the root
            string input10 = "a\\..";
            StringUtil.ChangeDirectoryVisit(input10);

            string input11 = "..";
            StringUtil.ChangeDirectoryVisit(input11);

            string input12 = ".";
            StringUtil.ChangeDirectoryVisit(input12);

            string input13 = "a\\..\\..";
            StringUtil.ChangeDirectoryVisit(input13);
        }
    }
}
