using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Bool4JsonConverter : JsonConverter<bool4>
{
    public override bool4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new bool4();

        reader.Read();
        value.x = reader.GetBoolean();

        reader.Read();
        value.y = reader.GetBoolean();

        reader.Read();
        value.z = reader.GetBoolean();

        reader.Read();
        value.w = reader.GetBoolean();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteBooleanValue(value.x);

        writer.WriteBooleanValue(value.y);

        writer.WriteBooleanValue(value.z);

        writer.WriteBooleanValue(value.w);

        writer.WriteEndArray();
    }
}
