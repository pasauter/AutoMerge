﻿using System.Collections.Generic;
using System.Linq;

namespace AutoMerge.Helpers
{
	internal static class EnumerableExtensions
	{
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
		{
			return items == null || !items.Any();
		}
	}
}