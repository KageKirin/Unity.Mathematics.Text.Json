using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Float3JsonConverter : JsonConverter<float3>
{
    public override float3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new float3();

        reader.Read();
        value.x = (float)reader.GetDouble("x");

        reader.Read();
        value.y = (float)reader.GetDouble("y");

        reader.Read();
        value.z = (float)reader.GetDouble("z");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.x);

        writer.WriteNumber("y", value.y);

        writer.WriteNumber("z", value.z);

        writer.WriteEndObject();
    }
}
