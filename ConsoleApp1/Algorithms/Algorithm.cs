namespace Algorithms
{
    public class Algorithm
    {
        public int GetLength(string wrt)
        {
            int count = 0;
            foreach (char f in wrt)
            {
                count++;
            }
            return count;
        }
        public bool Contains(string phrase, string wrt)
        {
            bool response = false;
            int wrtlength = GetLength(wrt) - GetLength(phrase);
            for (int i = 0; i < wrtlength; i++)
            {
                if (wrt.Substring(i, GetLength(phrase)) == phrase)
                {
                    response = true;
                }
            }
            return response;
        }
        public int IndexOf(string phrase, string wrt)
        {
            int index = 0;
            int wrtlength = GetLength(wrt) - GetLength(phrase);
            for (int i = 0; i < wrtlength; i++)
            {
                if (wrt.Substring(i, GetLength(phrase)) == phrase)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}