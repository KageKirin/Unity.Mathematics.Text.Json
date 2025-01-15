using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json.ArrayNotation;

public class QuaternionJsonConverter : JsonConverter<quaternion>
{
    public override quaternion Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new quaternion();

        reader.Read();
        value.value.x = (float)reader.GetDouble();

        reader.Read();
        value.value.y = (float)reader.GetDouble();

        reader.Read();
        value.value.z = (float)reader.GetDouble();

        reader.Read();
        value.value.w = (float)reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(
        Utf8JsonWriter writer,
        quaternion value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.value.x);

        writer.WriteNumberValue(value.value.y);

        writer.WriteNumberValue(value.value.z);

        writer.WriteNumberValue(value.value.w);

        writer.WriteEndArray();
    }
}
