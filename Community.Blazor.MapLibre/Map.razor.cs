using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Community.Blazor.MapLibre;

public partial class Map : ComponentBase, IAsyncDisposable
{
    [Parameter] 
    public string MapId { get; set; } = $"map-{Guid.NewGuid()}";

    [Parameter] public MapOptions Options { get; set; } = new ();

    [Inject] 
    private IJSRuntime JsRuntime { get; set; } = null!;
    private IJSObjectReference _jsModule = null!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeAsync<IJSObjectReference>("import", "https://unpkg.com/maplibre-gl@^5.0.0/dist/maplibre-gl.js");

            // Import your JavaScript module
            _jsModule = await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Community.Blazor.MapLibre/Map.razor.js");

            Options.Container = MapId;

            // Initialize the MapLibre map
            await _jsModule.InvokeVoidAsync("initializeMap", Options);
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_jsModule is not null)
        {
            try
            {
                await _jsModule.DisposeAsync();
            }
            catch (JSDisconnectedException)
            {
                //MS say that we should swallow this exception
            }
        }
    }
}