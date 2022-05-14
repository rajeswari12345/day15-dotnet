// See https://aka.ms/new-console-template for more information

using System;

namespace example
{

	class GFG
	{

		// Main Method
		static void Main(string[] args)
		{
			// Creating new indexes
			// Using Index() constructor
			var in1 = new Index(1, true);
			var in2 = new Index(3, false);

			// Getting the hash code
			// of the given index
			// Using GetHashCode() method
			var res1 = in1.GetHashCode();
			var res2 = in2.GetHashCode();

			// Displaying the index
			Console.WriteLine("Hash Code of Index: {0} is: {1} ", in1, res1);
			Console.WriteLine("Hash Code of Index: {0} is: {1} ", in2, res2);
		}
	}
}
