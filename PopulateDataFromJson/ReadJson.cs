using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace PopulateDataFromJson
{
	public class ReadJson
	{
		WebClient _wc;
		public dynamic GetData(WebClient wc)
		{
			_wc = wc;
			var jsonData = _wc.DownloadString("https://raw.githubusercontent.com/eduardomonteiro/projeto_opensource/master/test.json");
			var data = JsonConvert.DeserializeObject<dynamic>(jsonData);
			return data;
		}
		
	}
}
