using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Uint3x2JsonConverter : JsonConverter<uint3x2>
{
    public override uint3x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new uint3x2();

        reader.Read();
        value.c0.x = reader.GetUInt32();

        reader.Read();
        value.c0.y = reader.GetUInt32();

        reader.Read();
        value.c0.z = reader.GetUInt32();

        reader.Read();
        value.c1.x = reader.GetUInt32();

        reader.Read();
        value.c1.y = reader.GetUInt32();

        reader.Read();
        value.c1.z = reader.GetUInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint3x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c0.z);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c1.z);

        writer.WriteEndArray();
    }
}
