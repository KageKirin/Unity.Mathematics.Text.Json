using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Bool2x4JsonConverter : JsonConverter<bool2x4>
{
    public override bool2x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new bool2x4();

        reader.Read();
        value.c0.x = reader.GetBoolean();

        reader.Read();
        value.c0.y = reader.GetBoolean();

        reader.Read();
        value.c1.x = reader.GetBoolean();

        reader.Read();
        value.c1.y = reader.GetBoolean();

        reader.Read();
        value.c2.x = reader.GetBoolean();

        reader.Read();
        value.c2.y = reader.GetBoolean();

        reader.Read();
        value.c3.x = reader.GetBoolean();

        reader.Read();
        value.c3.y = reader.GetBoolean();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool2x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteBooleanValue(value.c0.x);

        writer.WriteBooleanValue(value.c0.y);

        writer.WriteBooleanValue(value.c1.x);

        writer.WriteBooleanValue(value.c1.y);

        writer.WriteBooleanValue(value.c2.x);

        writer.WriteBooleanValue(value.c2.y);

        writer.WriteBooleanValue(value.c3.x);

        writer.WriteBooleanValue(value.c3.y);

        writer.WriteEndArray();
    }
}
