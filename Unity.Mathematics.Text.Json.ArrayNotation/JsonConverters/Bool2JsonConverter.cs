using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Bool2JsonConverter : JsonConverter<bool2>
{
    public override bool2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new bool2();

        reader.Read();
        value.x = reader.GetBoolean();

        reader.Read();
        value.y = reader.GetBoolean();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteBooleanValue(value.x);

        writer.WriteBooleanValue(value.y);

        writer.WriteEndArray();
    }
}
