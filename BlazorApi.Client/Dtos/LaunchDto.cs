using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorApi.Client.Dtos
{
  public partial class LaunchDto
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("is_tentative")]
    public bool IsTentative { get; set; }

    [JsonPropertyName("launch_date_local")]
    public DateTimeOffset LaunchDateLocal { get; set; }

    [JsonPropertyName("mission_name")]
    public string MissionName { get; set; }

    [JsonPropertyName("launch_success")]
    public bool? LaunchSuccess { get; set; }
  }
}

