namespace Client
{
    public interface IReaderWriter
    {
        List<string> ReadWords();
        void WriteWords(List<string> rWords);
    }
}
