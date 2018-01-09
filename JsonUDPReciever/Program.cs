using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonUDPReciever
{
	class Program
	{
		private const int PORT = 11002;
		static void Main(string[] args)
		{

			JsonUDPReceiver s = new JsonUDPReceiver(PORT);
			s.Start();

			Console.WriteLine("End of receiver program...");
			Console.ReadLine();
		}
	}
}
