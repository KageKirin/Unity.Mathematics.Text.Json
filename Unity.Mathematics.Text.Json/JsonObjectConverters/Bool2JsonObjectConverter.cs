using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Bool2JsonObjectConverter : JsonConverter<bool2>
{
    public override bool2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new bool2();

        reader.Read();
        value.x = reader.GetBoolean("x");

        reader.Read();
        value.y = reader.GetBoolean("y");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("x", value.x);

        writer.WriteBoolean("y", value.y);

        writer.WriteEndObject();
    }
}
