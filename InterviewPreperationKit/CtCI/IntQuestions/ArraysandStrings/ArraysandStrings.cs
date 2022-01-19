using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPreperationKit.CtCI.IntQuestions.ArraysandStrings
{
    public class ArraysandStrings
    {
        #region IsUnique

        #region without data structures
        //Time complexity: O(n^2),O(1) space
        public static bool IsUniqueBruteForce(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        return false;
                    }
                }

            }
            return true;

        }
        //Time complexity: O(NlogN) sorting uses quicksort nlogn
        public static bool IsUniqueSort(string str)
        {
            char[] chArray = str.ToCharArray();

            // Using sorting
            Array.Sort(chArray);

            for (int i = 0; i < chArray.Length - 1; i++)
            {

                // if the adjacent elements are not
                // equal, move to next element
                if (chArray[i] != chArray[i + 1])
                    continue;

                // if at any time, 2 adjacent elements
                // become equal, return false
                else
                    return false;
            }

            return true;

        }
        #endregion

        #region  data structures
        #region bitvector

        //Time complexity: O(n) 

        public static bool IsUniqueCharsBitvector(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            var checker = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i] - 'a';

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }
        #endregion
        #region hashset
        //Time complexity: O(n) n is length of the string, Space complexity is O(1) or O(c) c is character set
        //hash table
        public static bool IsUniqueCharsHashset(String str)
        {
            var hashset = new HashSet<char>();
            foreach (var c in str)
            {
                if (hashset.Contains(c)) return false;
                hashset.Add(c);
            }

            return true;
        }
        #endregion

        #endregion

        #endregion

        #region Permutation

        //Time complexity: O(n(1+log(n)))
        public static bool IsPermutationBruteForce(string s1, string s2)
        {
            if (s1.Length != s2.Length || string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return false;
            var arr = s1.ToArray();//o(n) 
            var arr2 = s2.ToArray();
            Array.Sort(arr);//O(nlog(n))
            Array.Sort(arr2);
            return arr.SequenceEqual(arr2);
        }
        #region HashSet
        //Time complexity: O(n)
        public static bool IsPermutationHashSet(string original, string valueToTest)
        {
            if (original.Length != valueToTest.Length)
            {
                return false;
            }

            var letterCount = new Dictionary<char, int>();

            foreach (var character in original)
            {
                if (letterCount.ContainsKey(character))
                    letterCount[character]++;
                else
                    letterCount[character] = 1;
            }

            foreach (var character in valueToTest)
            {
                if (letterCount.ContainsKey(character))
                {
                    letterCount[character]--;
                    if (letterCount[character] < 0)
                    {
                        return false;
                    }
                }
                else return false;
            }

            return true;
        }


        public static bool IsPermutationArray(string original, string valueToTest)
        {
            bool result = false;
            int[] arr = new int[128];

            if (original.Length != valueToTest.Length)
                return result;

            foreach (char n in original)
            {
                arr[n]++;
            }
            foreach (char m in valueToTest)
            {
                if (arr[m] <= 0)
                {
                    return result;
                }
                else
                {
                    arr[m]--;

                }
            }
            result = true;

            return result;

        }
        #endregion

        #endregion
    }
}
