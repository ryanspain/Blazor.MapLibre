using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class FeatureFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "Feature";

    [JsonPropertyName("geometry")]
    public required IFeature Geometry { get; set; }

    [JsonPropertyName("properties")]
    public Dictionary<string, object>? Properties { get; set; }
}
