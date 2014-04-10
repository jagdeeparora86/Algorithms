using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
	public class ArrayStack
	{
		string[] s = null;
		int N = 0;

		public ArrayStack(int initialSize)
		{
			s = new string[initialSize];

		}

		public void push(string item )
		{
			if (N >= s.Length)
				resizeArray(2 * s.Length);
			s[N++] = item;
			
		}

		public string pop()
		{ 
			// you wanna first subtract the number and then send the item back
			if (N > 0 && N == s.Length / 4) resizeArray(s.Length / 4);
			return s[--N]; 
		}

		private void resizeArray(int newSize)
		{
			string[] copy = new string[newSize];
			for (int j = 0; j < s.Length; j++)
			{
				copy[j] = s[j];
			}
			s = copy;

		}
	}
}
