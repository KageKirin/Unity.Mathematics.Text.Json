using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class Int2JsonConverter : JsonConverter<int2>
{
    public override int2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new int2();

        reader.Read();
        value.x = reader.GetInt32();

        reader.Read();
        value.y = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, int2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.x);

        writer.WriteNumberValue(value.y);

        writer.WriteEndArray();
    }
}
