using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Float2JsonConverter : JsonConverter<float2>
{
    public override float2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new float2();

        reader.Read();
        value.x = (float)reader.GetDouble();

        reader.Read();
        value.y = (float)reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.x);

        writer.WriteNumberValue(value.y);

        writer.WriteEndArray();
    }
}
