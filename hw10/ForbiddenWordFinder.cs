namespace TextSearch
{
    internal class ForbiddenWordFinder : ProblemFinder
    {
        private string[] words = { "stupid", "damn" };
        private Dictionary<string, int> wordDictionary = new Dictionary<string, int>()
        {
            { "stupid", 0 },
            { "damn", 0 }
        };

        public ForbiddenWordFinder(string text) : base(text) { }

        public override Dictionary<string, int> FindProblem()
        {
            string[] words = Text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, 
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                foreach (string badWord in words)
                {
                    if (word.Equals(badWord, StringComparison.OrdinalIgnoreCase))
                    {
                        wordDictionary[badWord] += 1;
                    }
                }
            }

            return wordDictionary;
        }
    }
}
