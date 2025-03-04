using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class FeatureCollection : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "FeatureCollection";

    [JsonPropertyName("features")]
    public List<IFeature> Features { get; set; } = [];
}
