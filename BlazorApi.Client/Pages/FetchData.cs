using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApi.Client.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorApi.Client.Pages
{
  public partial class FetchData
  {
		[Inject]
		private HttpClient Http { get; set; }
	  private LaunchDto[] _launches;

	  protected override async Task OnInitializedAsync()
	  {
		  _launches = await Http.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");
	  }
  }
}
