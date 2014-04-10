using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Social network connectivity. Given a social network containing N members and a log file containing M 
 * timestamps at which times pairs of members formed friendships, design an algorithm to determine the 
 * earliest time at which all members are connected (i.e., every member is a friend of a friend of a 
 * friend ... of a friend). 
 * Assume that the log file is sorted by timestamp and that friendship is an equivalence relation. 
 * The running time of your algorithm should be MlogN or better and use extra space proportional to N.
 * 
 * 
*/

namespace SocialNetworks
{
	class Program
	{
		static void Main(string[] args)
		{

			QuickFind qf = new QuickFind(5);

			int frd1, frd2;
			frd1 = 1;
			frd2 = 4;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

			frd1 = 0; frd2 = 2;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

			frd1 = 0; frd2 = 3;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

			frd1 = 2; frd2 = 4;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

		}
	}
}
