using Microsoft.JSInterop;

namespace Community.Blazor.MapLibre;

public interface IMapLibrePlugin : IAsyncDisposable
{
    Task Initialize(IJSObjectReference map, IJSRuntime runtime);
}