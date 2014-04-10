using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Creating a stack functionality using resizeable array.

namespace StacksAndQueues
{
	class Program
	{
		static void Main(string[] args)
		{
			StackOfStrings stack = new StackOfStrings();
			ArrayStack arrayStack = new ArrayStack(1);
			string test = "This is - a - test string -";
			string[] words = test.Split(' ');
			foreach (string word in words)
			{
				if (word == "-")
				{
					Console.Write(stack.pop());
					Console.Write(" From array stack" + arrayStack.pop());
				}
				else
				{
					arrayStack.push(word);
					stack.push(word);
				}

			}
		}
	}
}
