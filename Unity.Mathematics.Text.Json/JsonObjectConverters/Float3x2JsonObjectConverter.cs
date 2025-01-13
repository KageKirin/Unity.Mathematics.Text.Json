using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Float3x2JsonObjectConverter : JsonConverter<float3x2>
{
    public override float3x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new float3x2();

        reader.Read();
        value.c0.x = (float)reader.GetDouble("m00");

        reader.Read();
        value.c0.y = (float)reader.GetDouble("m01");

        reader.Read();
        value.c0.z = (float)reader.GetDouble("m02");

        reader.Read();
        value.c1.x = (float)reader.GetDouble("m10");

        reader.Read();
        value.c1.y = (float)reader.GetDouble("m11");

        reader.Read();
        value.c1.z = (float)reader.GetDouble("m12");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float3x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m02", value.c0.z);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m12", value.c1.z);

        writer.WriteEndObject();
    }
}
