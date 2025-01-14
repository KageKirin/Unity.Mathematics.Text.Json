using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

#nullable enable

namespace Unity.Mathematics.Text.Json;

public static class Utf8JsonReaderExtension
{
    public static double GetDouble(this ref Utf8JsonReader reader, string propertyName)
    {
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException(
                $"Expected PropertyName token ('{propertyName}'), but got {reader.TokenType}"
            );
        }

        var propName = reader.GetString();
        if (propName != propertyName)
        {
            throw new JsonException($"Expected PropertyName token == '{propertyName}'");
        }

        reader.Read();
        return reader.GetDouble();
    }
}
