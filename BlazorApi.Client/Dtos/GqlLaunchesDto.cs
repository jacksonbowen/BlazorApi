using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorApi.Client.Dtos
{
	public partial class GqlData
	  {
		  [JsonPropertyName("data")]
		  public Data Data { get; set; }
	  }

	  public partial class Data
	  {
		  [JsonPropertyName("launches")]
		  public LaunchDto[] Launches { get; set; }
	  }

	  public partial class Launch
	  {
		  [JsonPropertyName("id")]
		  public string Id { get; set; }

		  [JsonPropertyName("is_tentative")]
		  public bool IsTentative { get; set; }

		  [JsonPropertyName("mission_name")]
		  public string MissionName { get; set; }

		  [JsonPropertyName("launch_date_local")]
		  public DateTimeOffset LaunchDateLocal { get; set; }
	  
  }
}
