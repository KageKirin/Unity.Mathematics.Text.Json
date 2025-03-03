using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Float2x3JsonConverter : JsonConverter<float2x3>
{
    public override float2x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new float2x3();

        reader.Read();
        value.c0.x = (float)reader.GetDouble("m00");

        reader.Read();
        value.c0.y = (float)reader.GetDouble("m01");

        reader.Read();
        value.c1.x = (float)reader.GetDouble("m10");

        reader.Read();
        value.c1.y = (float)reader.GetDouble("m11");

        reader.Read();
        value.c2.x = (float)reader.GetDouble("m20");

        reader.Read();
        value.c2.y = (float)reader.GetDouble("m21");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float2x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m20", value.c2.x);

        writer.WriteNumber("m21", value.c2.y);

        writer.WriteEndObject();
    }
}
