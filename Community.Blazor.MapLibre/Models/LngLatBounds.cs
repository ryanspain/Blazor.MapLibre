namespace Community.Blazor.MapLibre.Models;

/// <summary>
/// Represents bounds for geographical coordinates.
/// </summary>
public class LngLatBounds
{
    public LngLat Southwest { get; set; }
    public LngLat Northeast { get; set; }
}