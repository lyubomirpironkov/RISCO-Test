using System;

namespace RISCOHelper
{
    public class Helper
    {
		/// <summary>
		/// A method that determines whether there are two integers in the array with the desired sum
		/// </summary>
		/// <param name="arr">The array</param>
		/// <param name="sum">Desired sum between two elements</param>
		/// <returns></returns>
		public static bool ArrayHasSum(int[] arr, int sum)
		{
			var i = 0;
			var j = arr.Length - 1;

			Array.Sort(arr);

			while (i != j)
			{
				var indexesSum = arr[i] + arr[j];

				if (indexesSum > sum)
                {
					--j;
					continue;
				}
				else if (indexesSum < sum)
                {
					++i;
					continue;
				}
				else
                {
					Console.WriteLine($"Array length: {arr.Length}, Number of attempts: {++i}");
					return true;
				}
					
			}

			Console.WriteLine($"Array length: {arr.Length}, Number of attempts: {i}");
			return false;
		}
	}
}
