using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Uint4JsonConverter : JsonConverter<uint4>
{
    public override uint4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new uint4();

        reader.Read();
        value.x = reader.GetUInt32();

        reader.Read();
        value.y = reader.GetUInt32();

        reader.Read();
        value.z = reader.GetUInt32();

        reader.Read();
        value.w = reader.GetUInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.x);

        writer.WriteNumberValue(value.y);

        writer.WriteNumberValue(value.z);

        writer.WriteNumberValue(value.w);

        writer.WriteEndArray();
    }
}
