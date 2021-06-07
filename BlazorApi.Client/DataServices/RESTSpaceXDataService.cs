using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApi.Client.DataServices.Interfaces;
using BlazorApi.Client.Dtos;

namespace BlazorApi.Client.DataServices
{
	public class RESTSpaceXDataService : ISpaceXDataService
	{
		private readonly HttpClient _httpclient;
		public RESTSpaceXDataService(HttpClient httpclient)
		{
			_httpclient = httpclient;
		}
		public async Task<LaunchDto[]> GetAllLaunches()
		{
			return await _httpclient.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");
		}
	}
}
