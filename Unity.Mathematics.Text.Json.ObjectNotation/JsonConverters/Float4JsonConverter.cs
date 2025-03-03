using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Float4JsonConverter : JsonConverter<float4>
{
    public override float4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new float4();

        reader.Read();
        value.x = (float)reader.GetDouble("x");

        reader.Read();
        value.y = (float)reader.GetDouble("y");

        reader.Read();
        value.z = (float)reader.GetDouble("z");

        reader.Read();
        value.w = (float)reader.GetDouble("w");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.x);

        writer.WriteNumber("y", value.y);

        writer.WriteNumber("z", value.z);

        writer.WriteNumber("w", value.w);

        writer.WriteEndObject();
    }
}
