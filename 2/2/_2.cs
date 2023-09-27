using System.Text;

namespace __2
{
    public static class _2
    {
        public static int GetMaximum69Number(int num)
        {
            var numDigits = num.ToString();

            StringBuilder result = new StringBuilder();
            bool changed = false;
            
            foreach (var digit in numDigits) 
            {
                if (!changed && digit == '6')
                {
                    changed = true;
                    result.Append('9');
                    continue;
                }

                result.Append(digit);
            }

            return int.Parse(result.ToString());
        }
    }
}