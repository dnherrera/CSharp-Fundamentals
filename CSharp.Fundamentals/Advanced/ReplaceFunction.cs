using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Advanced
{
    public class ReplaceFunction
    {
        public static void Main(string[] args)
        {
            var toRemove = new string[] { "Permitted Use:", "." };
            var chunkOfTexts = GetChunkOfText();
            foreach (var item in chunkOfTexts)
            {
                var note1 = ReplaceTo(item.Key, toRemove);
                var note2 = ReplaceTo(item.Value, toRemove);

                Console.WriteLine(string.Join(". ", note1, $"{note2}."));
            }

        }

        private static string ReplaceTo(string note1, string[] textToSearches)
        {
           return textToSearches.Select(x => note1 = note1.Replace(x, string.Empty, StringComparison.OrdinalIgnoreCase).Trim()).ToList().LastOrDefault();
        }

        private static IDictionary<string, string> GetChunkOfText()
        {
            var chunkList = new Dictionary<string, string>
            {
                { "Permitted Use: Don.", " Don" },
                { "permitted Use: Don.", "Don." },
                { "Don ", "Don." },
            };

            return chunkList;
        }
    }
}
