using System.Text.Json;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public static class Utf8JsonReaderExtension
{
    public static double GetDouble(this ref Utf8JsonReader reader, string propertyName)
    {
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException(
                $"Expected PropertyName token ('{propertyName}'), but got {reader.TokenType}"
            );

        var propName = reader.GetString();
        if (propName != propertyName)
            throw new JsonException($"Expected PropertyName token == '{propertyName}'");

        reader.Read();
        return reader.GetDouble();
    }

    public static int GetInt32(this ref Utf8JsonReader reader, string propertyName)
    {
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException(
                $"Expected PropertyName token ('{propertyName}'), but got {reader.TokenType}"
            );

        var propName = reader.GetString();
        if (propName != propertyName)
            throw new JsonException($"Expected PropertyName token == '{propertyName}'");

        reader.Read();
        return reader.GetInt32();
    }

    public static uint GetUInt32(this ref Utf8JsonReader reader, string propertyName)
    {
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException(
                $"Expected PropertyName token ('{propertyName}'), but got {reader.TokenType}"
            );

        var propName = reader.GetString();
        if (propName != propertyName)
            throw new JsonException($"Expected PropertyName token == '{propertyName}'");

        reader.Read();
        return reader.GetUInt32();
    }

    public static bool GetBoolean(this ref Utf8JsonReader reader, string propertyName)
    {
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException(
                $"Expected PropertyName token ('{propertyName}'), but got {reader.TokenType}"
            );

        var propName = reader.GetString();
        if (propName != propertyName)
            throw new JsonException($"Expected PropertyName token == '{propertyName}'");

        reader.Read();
        return reader.GetBoolean();
    }
}
