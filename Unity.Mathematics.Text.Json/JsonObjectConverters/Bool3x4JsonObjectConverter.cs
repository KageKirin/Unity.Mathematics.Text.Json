using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Bool3x4JsonObjectConverter : JsonConverter<bool3x4>
{
    public override bool3x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new bool3x4();

        reader.Read();
        value.c0.x = reader.GetBoolean("m00");

        reader.Read();
        value.c0.y = reader.GetBoolean("m01");

        reader.Read();
        value.c0.z = reader.GetBoolean("m02");

        reader.Read();
        value.c1.x = reader.GetBoolean("m10");

        reader.Read();
        value.c1.y = reader.GetBoolean("m11");

        reader.Read();
        value.c1.z = reader.GetBoolean("m12");

        reader.Read();
        value.c2.x = reader.GetBoolean("m20");

        reader.Read();
        value.c2.y = reader.GetBoolean("m21");

        reader.Read();
        value.c2.z = reader.GetBoolean("m22");

        reader.Read();
        value.c3.x = reader.GetBoolean("m30");

        reader.Read();
        value.c3.y = reader.GetBoolean("m31");

        reader.Read();
        value.c3.z = reader.GetBoolean("m32");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool3x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("m00", value.c0.x);

        writer.WriteBoolean("m01", value.c0.y);

        writer.WriteBoolean("m02", value.c0.z);

        writer.WriteBoolean("m10", value.c1.x);

        writer.WriteBoolean("m11", value.c1.y);

        writer.WriteBoolean("m12", value.c1.z);

        writer.WriteBoolean("m20", value.c2.x);

        writer.WriteBoolean("m21", value.c2.y);

        writer.WriteBoolean("m22", value.c2.z);

        writer.WriteBoolean("m30", value.c3.x);

        writer.WriteBoolean("m31", value.c3.y);

        writer.WriteBoolean("m32", value.c3.z);

        writer.WriteEndObject();
    }
}
