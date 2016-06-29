using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20160628_SMSPortal_Challenge_4_Q3 {
    class Prefix {
        public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length) {
            return (from word in words.Distinct()
                    where words.Any(other =>
                        word.Length >= length && word.StartsWith(other.Substring(0, length)))
                    select word.Substring(0, length)).Distinct();
        }

        static void Main(string[] args) {
            foreach (var p in Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
                Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
