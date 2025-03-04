using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

[JsonDerivedType(typeof(FeatureCollection))]
[JsonDerivedType(typeof(FeatureFeature))]
[JsonDerivedType(typeof(PointFeature))]
[JsonDerivedType(typeof(PolygonFeature))]
public interface IFeature
{
    [JsonPropertyName("type")]
    public string Type { get; }
}
