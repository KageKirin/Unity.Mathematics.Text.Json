using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Uint4JsonConverter : JsonConverter<uint4>
{
    public override uint4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new uint4();

        reader.Read();
        value.x = reader.GetUInt32("x");

        reader.Read();
        value.y = reader.GetUInt32("y");

        reader.Read();
        value.z = reader.GetUInt32("z");

        reader.Read();
        value.w = reader.GetUInt32("w");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.x);

        writer.WriteNumber("y", value.y);

        writer.WriteNumber("z", value.z);

        writer.WriteNumber("w", value.w);

        writer.WriteEndObject();
    }
}
