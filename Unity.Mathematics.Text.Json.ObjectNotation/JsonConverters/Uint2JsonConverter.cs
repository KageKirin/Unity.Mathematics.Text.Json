using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Uint2JsonConverter : JsonConverter<uint2>
{
    public override uint2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new uint2();

        reader.Read();
        value.x = reader.GetUInt32("x");

        reader.Read();
        value.y = reader.GetUInt32("y");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.x);

        writer.WriteNumber("y", value.y);

        writer.WriteEndObject();
    }
}
