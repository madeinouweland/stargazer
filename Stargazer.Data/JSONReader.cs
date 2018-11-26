using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stargazer.Data
{
	public class JSONReader
	{
		public async Task<string> GetJSON()
		{
			var client = new HttpClient();

			var url = "http://www.astropical.space/astrodb/api.php?table=stars&which=distance&limit=32&format=json";
			var response = await client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				return json;
			}
			return null;
		}
	}
}
