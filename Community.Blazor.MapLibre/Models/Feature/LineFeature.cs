using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class LineFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "LineString";

    public required double[][] Coordinates { get; set; }
}
