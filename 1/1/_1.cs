namespace MinimumSum
{
    public static class _1
    {
        public static int GetMinimumSum(int num)
        {
            var orderedDigits = num.ToString().Order().ToArray();

            return int.Parse($"{orderedDigits[0]}{orderedDigits[3]}") + int.Parse($"{orderedDigits[1]}{orderedDigits[2]}");
        }
    }
}