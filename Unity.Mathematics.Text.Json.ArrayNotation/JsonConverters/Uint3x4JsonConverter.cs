using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Uint3x4JsonConverter : JsonConverter<uint3x4>
{
    public override uint3x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new uint3x4();

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
        value.c2.x = reader.GetUInt32();

        reader.Read();
        value.c2.y = reader.GetUInt32();

        reader.Read();
        value.c2.z = reader.GetUInt32();

        reader.Read();
        value.c3.x = reader.GetUInt32();

        reader.Read();
        value.c3.y = reader.GetUInt32();

        reader.Read();
        value.c3.z = reader.GetUInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint3x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c0.z);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c1.z);

        writer.WriteNumberValue(value.c2.x);

        writer.WriteNumberValue(value.c2.y);

        writer.WriteNumberValue(value.c2.z);

        writer.WriteNumberValue(value.c3.x);

        writer.WriteNumberValue(value.c3.y);

        writer.WriteNumberValue(value.c3.z);

        writer.WriteEndArray();
    }
}
