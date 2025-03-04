using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class MultiPointFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "MultiPoint";
}
