namespace DefaultNamespace
{
    public class main
    {
        public string AddBinary(string a, string b)
        {
            Stack<char> result = new Stack<char>();
            
            int lengthDiff = a.Length > b.Length ? a.Length - b.Length : b.Length - a.Length;
            string appendZeros = new string('0',lengthDiff);
            
            if (a.Length > b.Length) b = appendZeros + b; 
            else a = appendZeros + a;
            char sum = '0';
            char carry = '0';
            for ( var i = a.Length - 1; i >= 0; i--)
            {
                (sum, carry) = FindSum(a[i], b[i], carry);
                result.Push(sum);
            }

            result.Push(carry);

            bool isZero = true;
            while (isZero && result.Count>1)
            {
                if (result.Peek() == '0')
                {
                    result.Pop();
                }
                else isZero = false;
            }
            return new string(new string(result.ToArray()));
        }

        public (char, char) FindSum(char a, char b, char carry)
        {
            int sum = a + b + carry - '0'*3;
            if (sum == 0) return ('0', '0');
            if (sum == 1) return ('1', '0');
            if (sum == 2) return ('0', '1');
            if (sum == 3) return ('1', '1');
            return ('0', '0');
        }
    }
}