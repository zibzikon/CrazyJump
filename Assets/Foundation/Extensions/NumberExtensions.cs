namespace Kernel.Extensions
{
    public static class NumberExtensions
    {
        public static bool InRange(this int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    }
}