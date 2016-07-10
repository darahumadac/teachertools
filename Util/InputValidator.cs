using System;
using System.Text.RegularExpressions;

namespace TeacherTools.Utils
{
    public static class InputValidator
    {
        public static bool IsNumeric(string input)
        {
            if (Regex.IsMatch(input, @"^\d+$"))
            {
                return true;
            }

            return false;
        }

        public static bool IsEmpty(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                return true;
            }

            return false;
        }

        public static bool IsSubstringFound(string substring, string searchedString)
        {
            int foundIndex = searchedString.IndexOf(substring, StringComparison.OrdinalIgnoreCase);

            if (foundIndex >= 0)
            {
                return true;
            }

            return false;
        }
    }
}