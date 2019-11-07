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
            for (int i = 0; i <= wrtlength; i++)
            {
                if (wrt.Substring(i, GetLength(phrase)) == phrase)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public string Substring(int index, int count, string wrt)
        {
            string phrase = string.Empty;
            for (int i = index; i < index + count; i++)
            {
                phrase += wrt[i];
            }
            return phrase;
        }
        public string Replace(string oldPhrase, string newPhrase, string wrt)
        {
            int beginPoint = IndexOf(oldPhrase, wrt);
            int endPointofOldValue = beginPoint + oldPhrase.Length;
            string leftSide = Substring(0, beginPoint, wrt);
            string rightSide = Substring(endPointofOldValue, GetLength(wrt) - endPointofOldValue, wrt);
            return $"{leftSide}{newPhrase}{rightSide}";
        }
        public string Insert(int index, string insertword, string wrt)
        {
            string leftside = Substring(0, index, wrt);
            string rightside = Substring(index, GetLength(wrt) - GetLength(leftside), wrt);
            return $"{leftside}{insertword}{rightside}";
        }
        public string Remove(int index, string wrt)
        {
            string leftside = Substring(0, index, wrt);
            return $"{leftside}";
        }
        public string RemoveBetween(int index, int count, string wrt)
        {
            string remain = Substring(0, index, wrt);
            string remain2 = Substring(index + count, GetLength(wrt) - (index + count), wrt);
            return $"{remain}{remain2}";
        }
        public string PadLeft(int index, char symbol, string wrt)
        {
            int global = index - GetLength(wrt);
            string result = Generator(global, symbol);
            return $"{result}{wrt}";
        }
        public string PadRight(int index, char symbol, string wrt)
        {
            int global = index - GetLength(wrt);
            string result = Generator(global, symbol);
            return $"{wrt}{result}";
        }
        public string Generator(int total, char symbol)
        {
            string result = string.Empty;
            for (int i = 0; i < total; i++)
            {
                result += symbol;
            }
            return result;
        }
        public bool StartsWith(string phrase, string wrt)
        {
            bool response = false;
            if (Substring(0, GetLength(phrase), wrt) == phrase)
            {
                response = true;
            }
            return response;
        }
        public bool EndsWith(string phrase, string wrt)
        {
            bool response = false;
            string leftside = Substring(0, GetLength(wrt) - GetLength(phrase), wrt);
            if (Substring(GetLength(leftside), GetLength(wrt) - GetLength(leftside), wrt) == phrase)
            {
                response = true;
            }
            return response;
        }
        public int LastIndexOf(string phrase, string wrt)
        {
            int index = 0;
            int wrtlength = GetLength(wrt) - GetLength(phrase);
            for (int i = wrtlength; i > 0; i--)
            {
                if (wrt.Substring(i, GetLength(phrase)) == phrase)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public string TrimStart(char symbol, string wrt)
        {
            int count = 0;
            for (int i = 0; i < GetLength(wrt); i++)
            {
                if (wrt[i] == symbol)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            string newwrt = RemoveBetween(0, count, wrt);
            return newwrt;
        }
        public string TrimEnd(char symbol, string wrt)
        {
            int count = 0;
            for (int i = GetLength(wrt) - 1; i >= 0; i--)
            {
                if (wrt[i] == symbol)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            string newwrt = Substring(0, GetLength(wrt) - count, wrt);
            return newwrt;
        }
        public string Trim(char symbol, string wrt)
        {
            string newwrt = TrimStart(symbol, wrt);
            string newwrt2 = TrimEnd(symbol, newwrt);
            return newwrt2;
        }
    }
}