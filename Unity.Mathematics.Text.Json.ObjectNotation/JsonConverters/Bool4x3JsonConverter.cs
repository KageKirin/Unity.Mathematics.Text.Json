using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Bool4x3JsonConverter : JsonConverter<bool4x3>
{
    public override bool4x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new bool4x3();

        reader.Read();
        value.c0.x = reader.GetBoolean("m00");

        reader.Read();
        value.c0.y = reader.GetBoolean("m01");

        reader.Read();
        value.c0.z = reader.GetBoolean("m02");

        reader.Read();
        value.c0.w = reader.GetBoolean("m03");

        reader.Read();
        value.c1.x = reader.GetBoolean("m10");

        reader.Read();
        value.c1.y = reader.GetBoolean("m11");

        reader.Read();
        value.c1.z = reader.GetBoolean("m12");

        reader.Read();
        value.c1.w = reader.GetBoolean("m13");

        reader.Read();
        value.c2.x = reader.GetBoolean("m20");

        reader.Read();
        value.c2.y = reader.GetBoolean("m21");

        reader.Read();
        value.c2.z = reader.GetBoolean("m22");

        reader.Read();
        value.c2.w = reader.GetBoolean("m23");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool4x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("m00", value.c0.x);

        writer.WriteBoolean("m01", value.c0.y);

        writer.WriteBoolean("m02", value.c0.z);

        writer.WriteBoolean("m03", value.c0.w);

        writer.WriteBoolean("m10", value.c1.x);

        writer.WriteBoolean("m11", value.c1.y);

        writer.WriteBoolean("m12", value.c1.z);

        writer.WriteBoolean("m13", value.c1.w);

        writer.WriteBoolean("m20", value.c2.x);

        writer.WriteBoolean("m21", value.c2.y);

        writer.WriteBoolean("m22", value.c2.z);

        writer.WriteBoolean("m23", value.c2.w);

        writer.WriteEndObject();
    }
}
