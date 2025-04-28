using System.Text.Json.Serialization;

namespace Community.Blazor.MapLibre.Models;

public class Popup
{
    [JsonPropertyName("content")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Content { get; set; }

    [JsonPropertyName("lngLat")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LngLat? Coordinates { get; set; }
}

public class PopupBuilder
{
    private readonly Popup _popup = new Popup();

    public PopupBuilder SetContent(string content)
    {
        _popup.Content = content;
        return this;
    }

    public PopupBuilder SetCoordinates(LngLat coordinates)
    {
        _popup.Coordinates = coordinates;
        return this;
    }

    public Popup Build()
    {
        return _popup;
    }
}
