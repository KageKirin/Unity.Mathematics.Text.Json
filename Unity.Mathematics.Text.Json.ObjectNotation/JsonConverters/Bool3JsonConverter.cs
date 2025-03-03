using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Bool3JsonConverter : JsonConverter<bool3>
{
    public override bool3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new bool3();

        reader.Read();
        value.x = reader.GetBoolean("x");

        reader.Read();
        value.y = reader.GetBoolean("y");

        reader.Read();
        value.z = reader.GetBoolean("z");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("x", value.x);

        writer.WriteBoolean("y", value.y);

        writer.WriteBoolean("z", value.z);

        writer.WriteEndObject();
    }
}
