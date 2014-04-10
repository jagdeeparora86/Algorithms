using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Creating a stack functionality using resizeable array and linked list.
// Link list provides constant time solution even at worst case scenario but wastes time and space in linking.
// On the other hand array saves space and over all time is fast.

// better to use link list when need to manupalate data for each node faster then over all run time.
// better to use array where space is the concern.


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
