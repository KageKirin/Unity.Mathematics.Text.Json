using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Float2x4JsonConverter : JsonConverter<float2x4>
{
    public override float2x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new float2x4();

        reader.Read();
        value.c0.x = (float)reader.GetDouble();

        reader.Read();
        value.c0.y = (float)reader.GetDouble();

        reader.Read();
        value.c1.x = (float)reader.GetDouble();

        reader.Read();
        value.c1.y = (float)reader.GetDouble();

        reader.Read();
        value.c2.x = (float)reader.GetDouble();

        reader.Read();
        value.c2.y = (float)reader.GetDouble();

        reader.Read();
        value.c3.x = (float)reader.GetDouble();

        reader.Read();
        value.c3.y = (float)reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float2x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c2.x);

        writer.WriteNumberValue(value.c2.y);

        writer.WriteNumberValue(value.c3.x);

        writer.WriteNumberValue(value.c3.y);

        writer.WriteEndArray();
    }
}
