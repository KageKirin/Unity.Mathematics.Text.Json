using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Uint4x4JsonConverter : JsonConverter<uint4x4>
{
    public override uint4x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new uint4x4();

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
        value.c2.x = reader.GetUInt32("m20");

        reader.Read();
        value.c2.y = reader.GetUInt32("m21");

        reader.Read();
        value.c2.z = reader.GetUInt32("m22");

        reader.Read();
        value.c2.w = reader.GetUInt32("m23");

        reader.Read();
        value.c3.x = reader.GetUInt32("m30");

        reader.Read();
        value.c3.y = reader.GetUInt32("m31");

        reader.Read();
        value.c3.z = reader.GetUInt32("m32");

        reader.Read();
        value.c3.w = reader.GetUInt32("m33");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, uint4x4 value, JsonSerializerOptions options)
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

        writer.WriteNumber("m20", value.c2.x);

        writer.WriteNumber("m21", value.c2.y);

        writer.WriteNumber("m22", value.c2.z);

        writer.WriteNumber("m23", value.c2.w);

        writer.WriteNumber("m30", value.c3.x);

        writer.WriteNumber("m31", value.c3.y);

        writer.WriteNumber("m32", value.c3.z);

        writer.WriteNumber("m33", value.c3.w);

        writer.WriteEndObject();
    }
}
