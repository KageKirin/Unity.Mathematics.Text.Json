using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Float4x3JsonConverter : JsonConverter<float4x3>
{
    public override float4x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new float4x3();

        reader.Read();
        value.c0.x = (float)reader.GetDouble("m00");

        reader.Read();
        value.c0.y = (float)reader.GetDouble("m01");

        reader.Read();
        value.c0.z = (float)reader.GetDouble("m02");

        reader.Read();
        value.c0.w = (float)reader.GetDouble("m03");

        reader.Read();
        value.c1.x = (float)reader.GetDouble("m10");

        reader.Read();
        value.c1.y = (float)reader.GetDouble("m11");

        reader.Read();
        value.c1.z = (float)reader.GetDouble("m12");

        reader.Read();
        value.c1.w = (float)reader.GetDouble("m13");

        reader.Read();
        value.c2.x = (float)reader.GetDouble("m20");

        reader.Read();
        value.c2.y = (float)reader.GetDouble("m21");

        reader.Read();
        value.c2.z = (float)reader.GetDouble("m22");

        reader.Read();
        value.c2.w = (float)reader.GetDouble("m23");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, float4x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m02", value.c0.z);

        writer.WriteNumber("m03", value.c0.w);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m12", value.c1.z);

        writer.WriteNumber("m13", value.c1.w);

        writer.WriteNumber("m20", value.c2.x);

        writer.WriteNumber("m21", value.c2.y);

        writer.WriteNumber("m22", value.c2.z);

        writer.WriteNumber("m23", value.c2.w);

        writer.WriteEndObject();
    }
}
