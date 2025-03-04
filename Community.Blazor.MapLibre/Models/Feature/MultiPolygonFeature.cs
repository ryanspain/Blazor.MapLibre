using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class MultiPolygonFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "MultiPolygon";
}
