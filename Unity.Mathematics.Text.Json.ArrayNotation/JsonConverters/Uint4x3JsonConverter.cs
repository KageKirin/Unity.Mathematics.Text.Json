using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Uint4x3JsonConverter : JsonConverter<uint4x3>
{
    public override uint4x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new uint4x3();

        reader.Read();
        value.c0.x = reader.GetUInt32();

        reader.Read();
        value.c0.y = reader.GetUInt32();

        reader.Read();
        value.c0.z = reader.GetUInt32();

        reader.Read();
        value.c0.w = reader.GetUInt32();

        reader.Read();
        value.c1.x = reader.GetUInt32();

        reader.Read();
        value.c1.y = reader.GetUInt32();

        reader.Read();
        value.c1.z = reader.GetUInt32();

        reader.Read();
        value.c1.w = reader.GetUInt32();

        reader.Read();
        value.c2.x = reader.GetUInt32();

        reader.Read();
        value.c2.y = reader.GetUInt32();

        reader.Read();
        value.c2.z = reader.GetUInt32();

        reader.Read();
        value.c2.w = reader.GetUInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint4x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c0.z);

        writer.WriteNumberValue(value.c0.w);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c1.z);

        writer.WriteNumberValue(value.c1.w);

        writer.WriteNumberValue(value.c2.x);

        writer.WriteNumberValue(value.c2.y);

        writer.WriteNumberValue(value.c2.z);

        writer.WriteNumberValue(value.c2.w);

        writer.WriteEndArray();
    }
}
