using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;

namespace Community.Blazor.MapLibre.Converter;

public class OneOfJsonConverter<T1, T2> : JsonConverter<OneOf<T1, T2>>
{
    public override OneOf<T1, T2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException("This converter is only intended for serialization.");
    }

    public override void Write(Utf8JsonWriter writer, OneOf<T1, T2> value, JsonSerializerOptions options)
    {
        value.Switch(
            v1 => JsonSerializer.Serialize(writer, v1, options),
            v2 => JsonSerializer.Serialize(writer, v2, options)
        );
    }
}
