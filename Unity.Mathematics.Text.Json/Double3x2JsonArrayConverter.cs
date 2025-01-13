using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Double3x2JsonArrayConverter : JsonConverter<double3x2>
{
    public override double3x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new double3x2();

        reader.Read();
        value.c0.x = reader.GetDouble();

        reader.Read();
        value.c0.y = reader.GetDouble();

        reader.Read();
        value.c0.z = reader.GetDouble();

        reader.Read();
        value.c1.x = reader.GetDouble();

        reader.Read();
        value.c1.y = reader.GetDouble();

        reader.Read();
        value.c1.z = reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(
        Utf8JsonWriter writer,
        double3x2 value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c0.z);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c1.z);

        writer.WriteEndArray();
    }
}
