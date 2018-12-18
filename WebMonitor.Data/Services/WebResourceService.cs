using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebMonitor.Data.Services
{
	public class WebResourceService
	{
		public async Task<string> ReadSource(string url, CancellationToken token)
		{
			using (var httpClient = new HttpClient())
			{
				var message = await httpClient.GetAsync(url, HttpCompletionOption.ResponseContentRead, token);
				return await message.Content.ReadAsStringAsync();
			}
		}
	}
}
