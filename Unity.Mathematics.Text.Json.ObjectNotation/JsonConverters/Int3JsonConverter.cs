using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Int3JsonConverter : JsonConverter<int3>
{
    public override int3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new int3();

        reader.Read();
        value.x = reader.GetInt32("x");

        reader.Read();
        value.y = reader.GetInt32("y");

        reader.Read();
        value.z = reader.GetInt32("z");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, int3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.x);

        writer.WriteNumber("y", value.y);

        writer.WriteNumber("z", value.z);

        writer.WriteEndObject();
    }
}
