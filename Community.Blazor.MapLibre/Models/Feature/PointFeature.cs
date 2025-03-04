using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class PointFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "Point";

    [JsonPropertyName("coordinates")]
    public required double[] Coordinates { get; set; }
}
