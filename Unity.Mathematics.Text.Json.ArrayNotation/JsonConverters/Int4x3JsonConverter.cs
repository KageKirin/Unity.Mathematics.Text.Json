using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Int4x3JsonConverter : JsonConverter<int4x3>
{
    public override int4x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new int4x3();

        reader.Read();
        value.c0.x = reader.GetInt32();

        reader.Read();
        value.c0.y = reader.GetInt32();

        reader.Read();
        value.c0.z = reader.GetInt32();

        reader.Read();
        value.c0.w = reader.GetInt32();

        reader.Read();
        value.c1.x = reader.GetInt32();

        reader.Read();
        value.c1.y = reader.GetInt32();

        reader.Read();
        value.c1.z = reader.GetInt32();

        reader.Read();
        value.c1.w = reader.GetInt32();

        reader.Read();
        value.c2.x = reader.GetInt32();

        reader.Read();
        value.c2.y = reader.GetInt32();

        reader.Read();
        value.c2.z = reader.GetInt32();

        reader.Read();
        value.c2.w = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, int4x3 value, JsonSerializerOptions options)
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
