using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Uint3JsonConverter : JsonConverter<uint3>
{
    public override uint3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new uint3();

        reader.Read();
        value.x = reader.GetUInt32();

        reader.Read();
        value.y = reader.GetUInt32();

        reader.Read();
        value.z = reader.GetUInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.x);

        writer.WriteNumberValue(value.y);

        writer.WriteNumberValue(value.z);

        writer.WriteEndArray();
    }
}
