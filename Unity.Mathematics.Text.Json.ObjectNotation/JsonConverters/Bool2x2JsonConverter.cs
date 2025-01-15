using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class Bool2x2JsonConverter : JsonConverter<bool2x2>
{
    public override bool2x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new bool2x2();

        reader.Read();
        value.c0.x = reader.GetBoolean("m00");

        reader.Read();
        value.c0.y = reader.GetBoolean("m01");

        reader.Read();
        value.c1.x = reader.GetBoolean("m10");

        reader.Read();
        value.c1.y = reader.GetBoolean("m11");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("m00", value.c0.x);

        writer.WriteBoolean("m01", value.c0.y);

        writer.WriteBoolean("m10", value.c1.x);

        writer.WriteBoolean("m11", value.c1.y);

        writer.WriteEndObject();
    }
}
