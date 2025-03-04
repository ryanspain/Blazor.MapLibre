using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class MultiLineFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "MultiLineString";
}
