using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Uint4x2JsonConverter : JsonConverter<uint4x2>
{
    public override uint4x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new uint4x2();

        reader.Read();
        value.c0.x = reader.GetUInt32("m00");

        reader.Read();
        value.c0.y = reader.GetUInt32("m01");

        reader.Read();
        value.c0.z = reader.GetUInt32("m02");

        reader.Read();
        value.c0.w = reader.GetUInt32("m03");

        reader.Read();
        value.c1.x = reader.GetUInt32("m10");

        reader.Read();
        value.c1.y = reader.GetUInt32("m11");

        reader.Read();
        value.c1.z = reader.GetUInt32("m12");

        reader.Read();
        value.c1.w = reader.GetUInt32("m13");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint4x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m02", value.c0.z);

        writer.WriteNumber("m03", value.c0.w);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m12", value.c1.z);

        writer.WriteNumber("m13", value.c1.w);

        writer.WriteEndObject();
    }
}
