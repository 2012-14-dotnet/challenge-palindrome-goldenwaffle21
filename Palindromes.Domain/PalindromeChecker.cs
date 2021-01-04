namespace Palindromes.Domain
{
    public class PalindromeChecker
    {
        public string input {get;}
        public bool palindrome = true;

        public PalindromeChecker(string inp)
        {
            input = inp;
            Check();
        }

        public void Check()
        {
            s = input.ToLower().Trim().ToCharArray();
            int i = 0;
            for (int j=0;j<(s.Length()/2);j++)
            {
                if (!s[j].IsLetter()) {continue;}
                i++;
                if (!s[-i].IsLetter()) {i++;}
                if (s[j] != s[-i])
                {
                    palindrome = false;
                    break;
                }
            }
        }
    }
}