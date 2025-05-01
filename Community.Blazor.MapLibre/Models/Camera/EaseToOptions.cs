using System.Text.Json.Serialization;
using Community.Blazor.MapLibre.Models.Padding;
using OneOf;

namespace Community.Blazor.MapLibre.Models.Camera;

public class EaseToOptions : IAnimationOptions, ICameraOptions
{

    /// <summary>
    /// If `zoom` is specified, `around` determines the point around which the zoom is centered.
    /// </summary>
    [JsonPropertyName("animate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LngLat? Around { get; set; }
    
    [JsonPropertyName("delayEndEvents")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? DelayEndEvents { get; set; }
    
    [JsonPropertyName("easeId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EaseId { get; set; }

    [JsonPropertyName("noMoveStart")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? NoMoveStart { get; set; }
    
    [JsonPropertyName("padding")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OneOf<double, PaddingOptions>? Padding { get; set; }

    #region IAnimationOptions

    /// <summary>
    /// Determines whether animation occurs.
    /// </summary>
    /// <remarks>
    /// If set to <c>false</c>, no animation will occur.
    /// </remarks>
    [JsonPropertyName("animate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Animate { get; set; }

    /// <summary>
    /// The animation's duration, measured in milliseconds.
    /// </summary>
    [JsonPropertyName("duration")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Duration { get; set; }

    /// <summary>
    /// A function that takes a time in the range <c>0..1</c> and returns a number where <c>0</c> is the initial state and <c>1</c> is the final state.
    /// </summary>
    [JsonPropertyName("easing")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Func<double, double>? Easing { get; set; }

    /// <summary>
    /// If <c>true</c>, the animation is considered essential and will not be affected by <c>prefers-reduced-motion</c>.
    /// </summary>
    [JsonPropertyName("essential")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Essential { get; set; }

    /// <summary>
    /// Determines whether the camera remains at a constant height based on sea level in 3D maps.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>false</c>. If set to <c>true</c>, the zoom level is recalculated after the animation
    /// to maintain the correct distance from the camera to the center-coordinate-altitude.
    /// </remarks>
    [JsonPropertyName("freezeElevation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? FreezeElevation { get; set; }

    /// <summary>
    /// The offset of the target center relative to the real map container center at the end of the animation.
    /// </summary>
    [JsonPropertyName("offset")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PointLike? Offset { get; set; }

    #endregion

    #region ICameraOptions

    /// <summary>
    /// The desired pitch in degrees. The pitch is the angle towards the horizon
    /// measured in degrees with a range between 0 and 60 degrees. For example, pitch: 0 provides the appearance
    /// of looking straight down at the map, while pitch: 60 tilts the user's perspective towards the horizon.
    /// Increasing the pitch value is often used to display 3D objects.
    /// </summary>
    [JsonPropertyName("pitch")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Pitch { get; set; }

    /// <summary>
    /// The desired roll in degrees. The roll is the angle about the camera boresight.
    /// </summary>
    [JsonPropertyName("roll")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Roll { get; set; }

    /// <summary>
    /// The elevation of the center point in meters above sea level.
    /// </summary>
    [JsonPropertyName("elevation")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Elevation { get; set; }

    #region ICenterZoomBearing

    /// <summary>
    /// The desired center.
    /// </summary>
    public LngLat? Center { get; set; }

    /// <summary>
    /// The desired mercator zoom level.
    /// </summary>
    public double? Zoom { get; set; }

    /// <summary>
    /// The desired bearing in degrees. The bearing is the compass direction that
    ///  is "up". For example, `bearing: 90` orients the map so that east is up.
    /// </summary>
    public double? Bearing { get; set; }

    #endregion

    #endregion
}