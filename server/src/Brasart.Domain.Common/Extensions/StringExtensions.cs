using System;
using System.Text.RegularExpressions;

namespace Brasart.Domain.Common.Extensions
{
    public static class StringExtensions
    {

        public static bool HasNoSpecialCharacteres(this string text) => !new Regex("^[a-zA-Z0-9 ]*$").IsMatch(text);

        public static bool IsNotNullOrWhiteSpace(this string text) => !String.IsNullOrWhiteSpace(text);

        public static string SFormat(this string format, params object[] args) => String.Format(format, args);


    }



}
