using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Advanced
{
    /// <summary>
    /// Search and Replace in the Text Chunk
    /// </summary>
    public class SearchesInChunks
    {
        public static void Main(string[] args)
        {
            var nameList = GetPeopleName();
            var chunkOfTexts = GetChunkOfText();

            foreach (var chunk in chunkOfTexts)
            {
                Console.WriteLine(ReplaceFunction(chunk.Value, nameList.ToArray()));
            }
           
        }

        /// <summary>
        /// Replaces function.
        /// </summary>
        /// <param name="textChunk">The text chunk.</param>
        /// <param name="textToSearches">The text to searches.</param>
        /// <returns></returns>
        private static string ReplaceFunction(string textChunk, string[] textToSearches)
        {
            var isTextToSearchFound = textToSearches.Any(toSearch => textChunk.Contains(toSearch, StringComparison.OrdinalIgnoreCase));

            if (isTextToSearchFound)
            {
                textChunk = textToSearches.Select(x => textChunk = textChunk.Replace(x, new string('X', x.Length))).ToList().LastOrDefault();
            }

            return textChunk;
        }

        /// <summary>
        /// Gets the chunk of text.
        /// </summary>
        /// <returns> Chunk of Texts </returns>
        private static IDictionary<int, string> GetChunkOfText()
        {
            var chunkList = new Dictionary<int, string>
            {
                { 1, "There are many variations of passages of Lorem Ipsum available. John Smith and Dondon Herrera and Jimmy Neutron" },
                { 2, "No Names Here. There are many variations of passages of Lorem Ipsum available." },
                { 3, "Lorem Ipsum, John Smith, is simply dummy text of the printing and typesetting industry." },
                { 4, "Lorem Ipsum has been the industry's standard dummy, Dondon Herrera, text ever since the 1500s," },
                { 5, "Lorem Ipsum is that it has a more-or-less normal distribution of letters, Dondon Herrera, as opposed to using 'Content here, content here'" },
                { 6, "Contrary to popular belief, Dondon Herrera, Lorem Ipsum is not simply random text." }
            };

            return chunkList;
        }

        /// <summary>
        /// Gets the name of the people.
        /// </summary>
        /// <returns>List collection names</returns>
        private static List<string> GetPeopleName()
        {
            return new List<string>
            {
                "John Smith",
                "Dondon Herrera",
                "Jimmy Neutron"
            };
        }
    }
}
