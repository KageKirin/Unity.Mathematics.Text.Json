using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Double4JsonArrayConverter : JsonConverter<double4>
{
    public override double4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new double4();

        reader.Read();
        value.x = reader.GetDouble();

        reader.Read();
        value.y = reader.GetDouble();

        reader.Read();
        value.z = reader.GetDouble();

        reader.Read();
        value.w = reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, double4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.x);

        writer.WriteNumberValue(value.y);

        writer.WriteNumberValue(value.z);

        writer.WriteNumberValue(value.w);

        writer.WriteEndArray();
    }
}
