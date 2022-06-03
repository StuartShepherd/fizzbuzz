namespace FizzBuzz
{
    /// <summary>
    /// FizzBuzz implementation.
    /// </summary>
    public static class FizzBuzzHelper
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        private static bool IsDivisibleBy(
            int dividend,
            int divisor) =>
            dividend % divisor == 0;

        private static bool IsNegativeNumber(int value) =>
            value < 1;

        /// <summary>
        /// Returns the value if it is not divisible by 3 or 5.
        /// But returns "Fizz" if the value is divisible by 3, "Buzz" if the value is divisible by 5, and "FizzBuzz" if the value is divisible by both 3 and 5.
        /// </summary>
        /// <param name="value">Value to test</param>
        public static string Get(int value)
        {
            if (IsNegativeNumber(value))
                throw new ArgumentOutOfRangeException(nameof(value));

            var output = "";

            if (IsDivisibleBy(value, 3))
                output += Fizz;

            if (IsDivisibleBy(value, 5))
                output += Buzz;

            if (String.IsNullOrWhiteSpace(output))
                output = value.ToString();

            return output;
        }
    }
}
