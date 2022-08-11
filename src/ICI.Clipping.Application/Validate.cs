using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICI.Clipping.Application
{
	public class Validate
	{
		public ErrorDictionary CurrentErrorDictionary = new ErrorDictionary();

		public bool AddError(string prop, string msg)
		{
			var list = CurrentErrorDictionary.GetValueOrDefault(prop) ?? new List<string>();
			list.Add(msg);
			CurrentErrorDictionary[prop] = list;
			return false;
		}

		public static bool IsEmail(string s)
		{
			return Regex.IsMatch(s, @"\w+@\w+(\.\w+)+");
		}

		public static bool LengthBetween(string s, long min, long max)
		{
			s = s ?? "";
			return s.Length >= min && s.Length <= max;
		}

		public static bool Includes(string s, params string[] charList)
		{
			s = s ?? "";
			foreach (var cl in charList) {
				if (!Regex.IsMatch(s, cl))
					return false;
			}
			return true;
		}

		public static bool IsUrl(string s)
		{
			var result = default(Uri);
			var valid = true;
			valid &= Uri.TryCreate(s, UriKind.Absolute, out result);
			valid &= result?.Scheme.StartsWith("http") ?? false;
			return valid;
		}

		public static bool DatePast(DateTime d)
		{
			return d < DateTime.Now;
		}
	}
}
