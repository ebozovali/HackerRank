using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPreperationKit.DictionariesAndHashmaps
{
    public class RansomNote
    {

       public  static string CheckMagazine(string[] magazine, string[] note)
        {
            var dic = new SortedDictionary<string, int>();

            foreach (var group in magazine.GroupBy(x => x))
                dic.Add(group.Key, group.Count());

            foreach (var word in note.GroupBy(x => x))
            {
                if (!dic.TryGetValue(word.Key, out int count) || word.Count() > count)
                {
                    return "No";
                }
            }
            return "Yes";

            //string result = "Yes";
            //foreach (var word in note)
            //{
            //    if (!magazine.Any(n => n == word))
            //    {
            //        result = "No";
            //        break;
            //    }
            //    else if (note.Where(n => n == word).Count() > 1)
            //    {
            //        magazine[Array.IndexOf(magazine, word)] = "";
            //    }
            //}
            //return result;
            //Console.WriteLine(result);
        }
    }
}
