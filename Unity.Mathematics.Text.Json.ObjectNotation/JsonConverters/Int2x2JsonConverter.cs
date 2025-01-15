using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Int2x2JsonConverter : JsonConverter<int2x2>
{
    public override int2x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new int2x2();

        reader.Read();
        value.c0.x = reader.GetInt32("m00");

        reader.Read();
        value.c0.y = reader.GetInt32("m01");

        reader.Read();
        value.c1.x = reader.GetInt32("m10");

        reader.Read();
        value.c1.y = reader.GetInt32("m11");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, int2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteEndObject();
    }
}
