using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Int2x4JsonConverter : JsonConverter<int2x4>
{
    public override int2x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new int2x4();

        reader.Read();
        value.c0.x = reader.GetInt32("m00");

        reader.Read();
        value.c0.y = reader.GetInt32("m01");

        reader.Read();
        value.c1.x = reader.GetInt32("m10");

        reader.Read();
        value.c1.y = reader.GetInt32("m11");

        reader.Read();
        value.c2.x = reader.GetInt32("m20");

        reader.Read();
        value.c2.y = reader.GetInt32("m21");

        reader.Read();
        value.c3.x = reader.GetInt32("m30");

        reader.Read();
        value.c3.y = reader.GetInt32("m31");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public override void Write(Utf8JsonWriter writer, int2x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m20", value.c2.x);

        writer.WriteNumber("m21", value.c2.y);

        writer.WriteNumber("m30", value.c3.x);

        writer.WriteNumber("m31", value.c3.y);

        writer.WriteEndObject();
    }
}
