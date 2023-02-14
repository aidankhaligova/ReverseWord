namespace Client
{
    public class ReaderWriter : IReaderWriter
    {
        const string inPath = "C:\\Users\\User\\Desktop\\in.txt";
        const string outPath = "C:\\Users\\User\\Desktop\\out.txt";
        public List<string> ReadWords()
        {
            var sWords = File.ReadAllText(inPath);
            var words = sWords.Split("\r\n",StringSplitOptions.RemoveEmptyEntries).ToList();
            return words;
        }

        public void WriteWords(List<string> rWords)
        {
            File.WriteAllLines(outPath, rWords);
        }
    }
}
