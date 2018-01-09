using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using Newtonsoft.Json;

namespace JsonUDPReciever
{
	class JsonUDPReceiver
	{
		private readonly int Port;

		public JsonUDPReceiver(int port)
		{
			Port = port;
		}

		public void Start()
		{
			using (UdpClient client = new UdpClient(Port))
			{
				IPEndPoint AfsenderEp = new IPEndPoint(IPAddress.Any, 0);

				byte[] receive = client.Receive(ref AfsenderEp);

				string recivestr = Encoding.ASCII.GetString(receive);
				var deserializedobject = JsonConvert.DeserializeObject<Car>(recivestr);


				Console.WriteLine(deserializedobject);
			}
		}
	}
}
