using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Double4JsonConverter : JsonConverter<double4>
{
    public override double4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new double4();

        reader.Read();
        value.x = reader.GetDouble("x");

        reader.Read();
        value.y = reader.GetDouble("y");

        reader.Read();
        value.z = reader.GetDouble("z");

        reader.Read();
        value.w = reader.GetDouble("w");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, double4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.x);

        writer.WriteNumber("y", value.y);

        writer.WriteNumber("z", value.z);

        writer.WriteNumber("w", value.w);

        writer.WriteEndObject();
    }
}
