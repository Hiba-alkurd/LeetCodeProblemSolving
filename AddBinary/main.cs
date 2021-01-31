namespace DefaultNamespace
{
    public class main
    {
        public string AddBinary(string a, string b)
        {
            Stack<char> result = new Stack<char>();
            
            var maxString = "";
            var minString = "";
            if (a.Length > b.Length)
            {
                maxString = a;
                minString = b;
            }
            else
            {
                maxString = b;
                minString = a;
            }
            
            var sum = '0';
            var carry = '0';
            int j = maxString.Length - 1;
            for (int i = minString.Length - 1; i >= 0; i-- , j--)
            {
                (sum, carry) = FindBinarySum(maxString[j], minString[i], carry);
                result.Push(sum);
            }
            for (int i = j ; i >=0; i--)
            {
                (sum, carry) = FindBinarySum(maxString[i], '0', carry);
                result.Push(sum);
            }
            result.Push(carry);

            var isZero = true;
            while (isZero && result.Count > 1)
            {
                if (result.Peek() == '0') result.Pop();
                else isZero = false;
            }
            return new string(result.ToArray());
        }

        private (char, char) FindBinarySum(char a, char b, char carry)
        {
            var sum = a + b + carry - '0'*3;
            return sum switch
            {
                0 => ('0', '0'),
                1 => ('1', '0'),
                2 => ('0', '1'),
                3 => ('1', '1'),
                _ => throw new Exception("invalid characters")
            };
        }
    }
}