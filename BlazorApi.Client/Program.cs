using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlazorApi.Client.DataServices;
using BlazorApi.Client.DataServices.Interfaces;

namespace BlazorApi.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);

      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]) });
      
      builder.Services.AddHttpClient<ISpaceXDataService, GraphQLSpaceXDataService>
	      (spds => spds.BaseAddress = new Uri(builder.Configuration["api_base_url"]));

	    await builder.Build().RunAsync();
    }
  }
}
