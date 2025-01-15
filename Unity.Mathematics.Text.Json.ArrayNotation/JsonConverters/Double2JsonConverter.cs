using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Double2JsonConverter : JsonConverter<double2>
{
    public override double2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new double2();

        reader.Read();
        value.x = reader.GetDouble();

        reader.Read();
        value.y = reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, double2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.x);

        writer.WriteNumberValue(value.y);

        writer.WriteEndArray();
    }
}
