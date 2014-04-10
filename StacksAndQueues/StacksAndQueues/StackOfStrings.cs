using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
	class StackOfStrings
	{
		private Node first = null;
		private class Node
		{
			public string item;
			public Node next;

		}

		public void push (string item)
		{
			Node oldFirst = first;
			first = new Node();
			first.item = item;
			first.next = oldFirst;

		}

		public string pop()
		{
			string oldItem = first.item;
			first = first.next;
			return oldItem;
		}

	}
}
