using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Float4x4JsonArrayConverter : JsonConverter<float4x4>
{
    public override float4x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new float4x4();

        reader.Read();
        value.c0.x = (float)reader.GetDouble();

        reader.Read();
        value.c0.y = (float)reader.GetDouble();

        reader.Read();
        value.c0.z = (float)reader.GetDouble();

        reader.Read();
        value.c0.w = (float)reader.GetDouble();

        reader.Read();
        value.c1.x = (float)reader.GetDouble();

        reader.Read();
        value.c1.y = (float)reader.GetDouble();

        reader.Read();
        value.c1.z = (float)reader.GetDouble();

        reader.Read();
        value.c1.w = (float)reader.GetDouble();

        reader.Read();
        value.c2.x = (float)reader.GetDouble();

        reader.Read();
        value.c2.y = (float)reader.GetDouble();

        reader.Read();
        value.c2.z = (float)reader.GetDouble();

        reader.Read();
        value.c2.w = (float)reader.GetDouble();

        reader.Read();
        value.c3.x = (float)reader.GetDouble();

        reader.Read();
        value.c3.y = (float)reader.GetDouble();

        reader.Read();
        value.c3.z = (float)reader.GetDouble();

        reader.Read();
        value.c3.w = (float)reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float4x4 value, JsonSerializerOptions options)
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

        writer.WriteNumberValue(value.c2.x);

        writer.WriteNumberValue(value.c2.y);

        writer.WriteNumberValue(value.c2.z);

        writer.WriteNumberValue(value.c2.w);

        writer.WriteNumberValue(value.c3.x);

        writer.WriteNumberValue(value.c3.y);

        writer.WriteNumberValue(value.c3.z);

        writer.WriteNumberValue(value.c3.w);

        writer.WriteEndArray();
    }
}
