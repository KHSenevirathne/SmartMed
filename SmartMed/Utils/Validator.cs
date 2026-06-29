using System.Text.RegularExpressions;

namespace SmartMed.Utils
{
    public static class Validator
    {
        private static readonly Regex EmailPattern =
            new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        public static bool IsNotEmpty(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool IsValidEmail(string value)
        {
            return IsNotEmpty(value) && EmailPattern.IsMatch(value.Trim());
        }

        public static bool IsValidPassword(string value, int minLength = 6)
        {
            return value != null && value.Length >= minLength;
        }

        public static bool TryParseInt(string text, out int value)
        {
            return int.TryParse(text == null ? null : text.Trim(), out value);
        }

        public static bool TryParseDecimal(string text, out decimal value)
        {
            return decimal.TryParse(text == null ? null : text.Trim(), out value);
        }

        public static bool IsPositiveInt(string text)
        {
            int value;
            return TryParseInt(text, out value) && value > 0;
        }

        public static bool IsNonNegativeInt(string text)
        {
            int value;
            return TryParseInt(text, out value) && value >= 0;
        }

        public static bool IsPositiveDecimal(string text)
        {
            decimal value;
            return TryParseDecimal(text, out value) && value > 0m;
        }

        public static bool IsNonNegativeDecimal(string text)
        {
            decimal value;
            return TryParseDecimal(text, out value) && value >= 0m;
        }
    }
}
