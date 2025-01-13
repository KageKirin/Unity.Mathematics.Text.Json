using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Bool3JsonArrayConverter : JsonConverter<bool3>
{
    public override bool3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new bool3();

        reader.Read();
        value.x = reader.GetBoolean();

        reader.Read();
        value.y = reader.GetBoolean();

        reader.Read();
        value.z = reader.GetBoolean();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, bool3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteBooleanValue(value.x);

        writer.WriteBooleanValue(value.y);

        writer.WriteBooleanValue(value.z);

        writer.WriteEndArray();
    }
}
