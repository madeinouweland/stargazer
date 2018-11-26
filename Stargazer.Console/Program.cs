using System;
using System.Threading.Tasks;
using Stargazer.Data;

namespace Stargazer.Console2
{
	class Program
	{
		static void Main(string[] args)
		{

			Task.Run(async () =>
			{
				Console.WriteLine("Retrieving data");
				var reader = new JSONReader();
				var json = await reader.GetJSON();


				var stars = Serializer.Deserialize(json);
				Console.WriteLine(stars.hipstars.Count);

			}).Wait();



		}


	}
}
