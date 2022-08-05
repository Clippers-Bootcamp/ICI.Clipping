using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICI.Clipping.Application
{
	public static class Validators
	{
		public static bool IsEmail(string s)
		{
			return Regex.IsMatch(s, @"\w+@\w+(\.\w+)+");
		}

		public static bool LengthBetween(string s, long min, long max)
		{
			return s.Length >= min && s.Length <= max;
		}

		public static bool Includes(string s, params string[] charList)
		{
			foreach (var cl in charList) {
				if (!Regex.IsMatch(s, cl))
					return false;
			}
			return true;
		}
	}
}
