using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Uint3x3JsonConverter : JsonConverter<uint3x3>
{
    public override uint3x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new uint3x3();

        reader.Read();
        value.c0.x = reader.GetUInt32("m00");

        reader.Read();
        value.c0.y = reader.GetUInt32("m01");

        reader.Read();
        value.c0.z = reader.GetUInt32("m02");

        reader.Read();
        value.c1.x = reader.GetUInt32("m10");

        reader.Read();
        value.c1.y = reader.GetUInt32("m11");

        reader.Read();
        value.c1.z = reader.GetUInt32("m12");

        reader.Read();
        value.c2.x = reader.GetUInt32("m20");

        reader.Read();
        value.c2.y = reader.GetUInt32("m21");

        reader.Read();
        value.c2.z = reader.GetUInt32("m22");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint3x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m02", value.c0.z);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m12", value.c1.z);

        writer.WriteNumber("m20", value.c2.x);

        writer.WriteNumber("m21", value.c2.y);

        writer.WriteNumber("m22", value.c2.z);

        writer.WriteEndObject();
    }
}
