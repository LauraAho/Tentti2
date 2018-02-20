using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tehtävä_2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Piste> Pisteet = new List<Piste>();

			Piste a = new Piste("A", 1, 2);
			Piste b = new Piste("B", 2, 3);
			Piste k;

			Pisteet.Add(a);
			Pisteet.Add(b);

			string c = JsonConvert.SerializeObject(Pisteet);
			Console.WriteLine(c);

			/*
			FileStream stream = new FileStream("C:\\tmp\\data.bin",
			   FileMode.Open);

			BinaryReader reader = new BinaryReader(stream);

			reader.BaseStream.Seek(0, SeekOrigin.Begin);
			string s;
			double x;
			double y;
			while (reader.ReadString()!=null)
			{
				s = reader.ReadString();
				x = reader.ReadDouble();
				y = reader.ReadDouble();
				k = new Tehtävä_2.Piste(s, x, y);
				Pisteet.Add(k);
			}

			c = JsonConvert.SerializeObject(Pisteet);
			Console.WriteLine(c);
			*/
			Console.Read();
		}
	}
}
