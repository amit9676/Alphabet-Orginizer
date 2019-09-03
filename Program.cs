using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] abc = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r'
            , 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            List<char> abcd = new List<char>(abc);

            Console.WriteLine("enter array size: ");
            int size = int.Parse(Console.ReadLine());

            string[] arrr = new string[size];

            Console.WriteLine("enter words: ");
            for (int i = 0; i < arrr.Length; i++)
            {
                arrr[i] = Console.ReadLine();
            }

            List<string> arr = new List<string>(arrr);
            
            Console.WriteLine();
            List<string> arr2 = new List<string>(size);
            
            for (int i = 0; i < size - 1; i++)
            {
                string first = arr[0];
                for (int j = 0; j < arr.Count; j++)
                {
                    for (int k = 0; k < abcd.Count; k++)
                    {
                        if ((k < first.Length) && (k < arr[j].Length))
                        {
                            if (abcd.IndexOf(arr[j][k]) < abcd.IndexOf(first[k]))
                            {
                                first = arr[j];
                                break;
                            }
                            else if (abcd.IndexOf(arr[j][k]) > abcd.IndexOf(first[k]))
                                break;
                        }
                        else if ((k == first.Length) || (k == arr[j].Length))
                        {
                            if (first.Length > arr[j].Length)
                            {
                                first = arr[j];
                                break;
                            }
                            else if (first.Length < arr[j].Length)
                                break;
                        }
                    }
                }
                arr2.Add(first);
                arr.Remove(first);
            }
            foreach (string item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arr[0]);
            Console.ReadLine();




            /* if ((i < word1.Length) && (i < word2.Length))
                {
                    if (abcd.IndexOf(word1[i]) < abcd.IndexOf(word2[i]))
                    {
                        Console.WriteLine(word1);
                        break;
                    }
                    else if (abcd.IndexOf(word1[i]) > abcd.IndexOf(word2[i]))
                    {
                        Console.WriteLine(word2);
                        break;
                    }
                }
                else if ((i == word1.Length) || (i == word2.Length))
                {
                    if (word1.Length > word2.Length)
                    {
                        Console.WriteLine(word2);
                        break;
                    }
                    else if (word2.Length > word1.Length)
                    {
                        Console.WriteLine(word1);
                        break;
                    }
                }*/
            //Console.WriteLine();
        }

        static void abcdef()
        {
            
        }
    }
}
