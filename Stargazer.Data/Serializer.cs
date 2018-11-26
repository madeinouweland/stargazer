using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Stargazer.Data
{
	public class Serializer
	{
		public static RootObject Deserialize(string json)
		{
			var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
			var ser = new DataContractJsonSerializer(typeof(RootObject));
			var o = ser.ReadObject(ms) as RootObject;
			ms.Close();
			return o;
		}
	}
}
