using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Int2x3JsonArrayConverter : JsonConverter<int2x3>
{
    public override int2x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new int2x3();

        reader.Read();
        value.c0.x = reader.GetInt32();

        reader.Read();
        value.c0.y = reader.GetInt32();

        reader.Read();
        value.c1.x = reader.GetInt32();

        reader.Read();
        value.c1.y = reader.GetInt32();

        reader.Read();
        value.c2.x = reader.GetInt32();

        reader.Read();
        value.c2.y = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, int2x3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c2.x);

        writer.WriteNumberValue(value.c2.y);

        writer.WriteEndArray();
    }
}
