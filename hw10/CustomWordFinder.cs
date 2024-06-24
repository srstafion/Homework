namespace TextSearch
{
    internal class CustomWordFinder : ProblemFinder
    {
        private string[] _words;
        private Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

        public CustomWordFinder(string text, string[] words) : base(text)
        {
            _words = words;
            foreach (var word in _words)
            {
                wordDictionary.Add(word, 0);
            }
        }

        public override Dictionary<string, int> FindProblem()
        {
            string[] words = Text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, 
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                foreach (string badWord in _words)
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
