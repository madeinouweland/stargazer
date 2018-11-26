using System;
using System.Collections.Generic;

namespace Stargazer.Data
{
	public class Info
	{
		public string source { get; set; }
		public int timestamp { get; set; }
	}

	public class Hipstar
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desig { get; set; }
		public int hip { get; set; }
		public int hd { get; set; }
		public int sao { get; set; }
		public string con { get; set; }
		public double mag { get; set; }
		public double dist { get; set; }
		public double rad { get; set; }
		public string spk { get; set; }
		public double bvc { get; set; }
		public int teff { get; set; }
		public double mass { get; set; }
		public double radius { get; set; }
		public double ra { get; set; }
		public double de { get; set; }
	}

	public class RootObject
	{
		public Info info { get; set; }
		public List<Hipstar> hipstars { get; set; }
	}
}
