using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Feature;

public class PolygonFeature : IFeature
{
    [JsonPropertyName("type")]
    public string Type => "Polygon";

    /// <summary>
    /// Coordinates of a Polygon are an array of LinearRing coordinate arrays.
    /// The first element in the array represents the exterior ring.
    /// Any subsequent elements represent interior rings (or holes).
    /// <example>
    /// No holes:
    /// <code>
    /// {
    ///   "type": "Polygon",
    ///   "coordinates": [
    ///     [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ]
    ///   ]
    /// }
    /// </code>
    /// </example>
    /// <example>
    /// With holes:
    /// <code>
    /// {
    ///   "type": "Polygon",
    ///   "coordinates": [
    ///     [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ],
    ///     [ [100.2, 0.2], [100.8, 0.2], [100.8, 0.8], [100.2, 0.8], [100.2, 0.2] ]
    ///   ]
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public required double[][][] Coordinates { get; set; }
}
