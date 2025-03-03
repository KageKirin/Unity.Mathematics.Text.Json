using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Double4x2JsonConverter : JsonConverter<double4x2>
{
    public override double4x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new double4x2();

        reader.Read();
        value.c0.x = reader.GetDouble();

        reader.Read();
        value.c0.y = reader.GetDouble();

        reader.Read();
        value.c0.z = reader.GetDouble();

        reader.Read();
        value.c0.w = reader.GetDouble();

        reader.Read();
        value.c1.x = reader.GetDouble();

        reader.Read();
        value.c1.y = reader.GetDouble();

        reader.Read();
        value.c1.z = reader.GetDouble();

        reader.Read();
        value.c1.w = reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(
        Utf8JsonWriter writer,
        double4x2 value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c0.z);

        writer.WriteNumberValue(value.c0.w);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c1.z);

        writer.WriteNumberValue(value.c1.w);

        writer.WriteEndArray();
    }
}
