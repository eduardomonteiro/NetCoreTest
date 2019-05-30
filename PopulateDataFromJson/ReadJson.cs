using Domain;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace PopulateDataFromJson
{
	public class ReadJson
	{
		WebClient _wc;
		public dynamic GetData(WebClient wc)
		{
			_wc = wc;
			var jsonData = _wc.DownloadString("https://raw.githubusercontent.com/eduardomonteiro/projeto_opensource/master/test.json");
			var data = JsonConvert.DeserializeObject<List<Product>>(jsonData);
			List<Product> products = new List<Product>();

			foreach (var productJson in data)
			{
				if (productJson.Specifications.Genres.ToString().Contains('['))
				{
					//productJson.Specifications.Genre = new string[] { productJson.Specifications.Genres.ToString() };
				}
				else
				{
					productJson.Specifications.Genre = new string[] { productJson.Specifications.Genres.ToString() };
				}
			}

			return data;
		}

	}
}
