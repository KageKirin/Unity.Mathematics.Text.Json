using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Bool2JsonConverter : JsonConverter<bool2>
{
    public delegate bool2 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        bool2 value,
        JsonSerializerOptions options
    );

    public bool2 ReadAsArray(
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

    public void WriteAsArray(Utf8JsonWriter writer, bool2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteBooleanValue(value.x);

        writer.WriteBooleanValue(value.y);

        writer.WriteEndArray();
    }

    public bool2 ReadAsObject(
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

    public void WriteAsObject(Utf8JsonWriter writer, bool2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("x", value.x);

        writer.WriteBoolean("y", value.y);

        writer.WriteEndObject();
    }

    public bool2 ReadCompatible(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) =>
        reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException(),
        };

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Bool2JsonConverter(
        JsonTokenType readerTokenType = JsonTokenType.None,
        JsonTokenType writerTokenType = JsonTokenType.None
    )
        : base()
    {
        readFunc = readerTokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray,
            JsonTokenType.StartObject => ReadAsObject,
            _ => ReadCompatible,
        };

        writeFunc = writerTokenType switch
        {
            JsonTokenType.StartArray => WriteAsArray,
            JsonTokenType.StartObject => WriteAsObject,
            _ => WriteAsArray, //!< we need _some_ kind of default
        };
    }

    public override bool2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, bool2 value, JsonSerializerOptions options) =>
        writeFunc(writer, value, options);
}
