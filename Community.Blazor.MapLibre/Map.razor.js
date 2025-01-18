const mapInstances = {};

const MapInterop = {
    /**
     * Initializes a MapLibre map instance with the given options and connects it to a .NET reference for interop functionality.
     *
     * @param {Object} options - Configuration options for initializing the MapLibre map instance.
     * @param {Object} dotnetReference - A .NET instance reference for invoking interop methods.
     */
    initializeMap: (options, dotnetReference) => {
        const map = new maplibregl.Map(options);

        mapInstances[options.container] = map;

        map.on('load', function () {
            dotnetReference.invokeMethodAsync("OnLoadCallback")
        });
    },
    /**
     * Attaches an event listener to a specified map instance.
     *
     * @param {string} container - The identifier for the specific map instance.
     * @param {string} eventType - The type of event to listen for (e.g., "click", "zoom").
     * @param {object} dotnetReference - A reference to a .NET object used for invoking asynchronous methods.
     * @param {object} [args] - Optional argument to pass when adding the event listener. If not provided, the event is added without additional arguments.
     */
    on: (container, eventType, dotnetReference, args) => {
        if (args === undefined || args === null) {
            mapInstances[container].on(eventType, function (e) {
                e.target = null; // Remove map to prevent circular references.
                const result = JSON.stringify(e);
                dotnetReference.invokeMethodAsync('Invoke', result)
            })
        }
        else {
           mapInstances[container].on(eventType, args, function (e) {
                e.target = null; // Remove map to prevent circular references.
                const result = JSON.stringify(e);
                dotnetReference.invokeMethodAsync('Invoke', result)
            })
        }
    }
}
export { MapInterop };