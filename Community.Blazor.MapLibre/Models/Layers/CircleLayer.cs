using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models.Layers;

public class CircleLayer : Layer<CircleLayerLayout, CircleLayerPaint>
{
    /// <summary>
    ///  <inheritdoc/>
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public override LayerType Type => LayerType.Circle;

    /// <summary>
    /// Gets or sets the name of the source to be used for this layer.
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; set; }

    [JsonPropertyName("circle-sort-key")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CircleSortKey { get; set; }

    [JsonPropertyName("visibility")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Visibility? Visibility { get; set; }
}

public class CircleLayerLayout;

public class CircleLayerPaint
{
    [JsonPropertyName("circle-radius")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CircleRadius { get; set; }

    [JsonPropertyName("circle-color")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CircleColor { get; set; }

    [JsonPropertyName("circle-blur")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CircleBlur { get; set; }

    [JsonPropertyName("circle-opacity")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CircleOpacity { get; set; }

    [JsonPropertyName("circle-translate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double[]? CircleTranslate { get; set; }

    [JsonPropertyName("circle-translate-anchor")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapViewport? CircleTranslateAnchor { get; set; }

    [JsonPropertyName("circle-pitch-scale")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapViewport? CirclePitchScale { get; set; }

    [JsonPropertyName("circle-pitch-alignment")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapViewport? CirclePitchAlignment { get; set; }

    [JsonPropertyName("circle-stroke-width")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CircleStrokeWidth { get; set; }

    [JsonPropertyName("circle-stroke-color")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CircleStrokeColor { get; set; }

    [JsonPropertyName("circle-stroke-opacity")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CircleStrokeOpacity { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MapViewport
{
    [JsonStringEnumMemberName("map")]
    Map,

    [JsonStringEnumMemberName("viewport")]
    Viewport
}
