using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Module14.Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            Dictionary<string, int> ans = new Dictionary<string, int>();

            ans = CountWords(target);
            foreach(var x in ans)
            {
                Console.WriteLine($"Word: {x.Key}\tCount: {x.Value}");
            }
        }

        public static Dictionary<string, int> CountWords(string target)
        {
            Dictionary<string, int> ans = new Dictionary<string, int>();

            target = target.Replace(",", "");
            target = target.Replace(".", "");
            string[] targetArr = target.ToLower().Split(' ');

            foreach(string x in targetArr)
            {
                if (!ans.ContainsKey(x))
                    ans.Add(x, 1);
                else ans[x] += 1;
            }
            return ans;
        }
    }
}
