namespace Service
{
    public class ReverseService : IReverseService
    {
        public List<string> Reverse(List<string> words)
        {
            List<string> result = new();
            foreach (var word in words)
            {
                var reverse = word.Reverse();
                string rWord = "";
                foreach (var item in reverse)
                {
                    rWord += item.ToString();
                }
                result.Add(rWord);
            }
            return result;
        }
    }
}
