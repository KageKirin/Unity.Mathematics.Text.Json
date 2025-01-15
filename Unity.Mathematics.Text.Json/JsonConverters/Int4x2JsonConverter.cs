using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Int4x2JsonConverter : JsonConverter<int4x2>
{
    public delegate int4x2 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        int4x2 value,
        JsonSerializerOptions options
    );

    public int4x2 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new int4x2();

        reader.Read();
        value.c0.x = reader.GetInt32();

        reader.Read();
        value.c0.y = reader.GetInt32();

        reader.Read();
        value.c0.z = reader.GetInt32();

        reader.Read();
        value.c0.w = reader.GetInt32();

        reader.Read();
        value.c1.x = reader.GetInt32();

        reader.Read();
        value.c1.y = reader.GetInt32();

        reader.Read();
        value.c1.z = reader.GetInt32();

        reader.Read();
        value.c1.w = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, int4x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();

        writer.WriteNumberValue(value.c0.x);

        writer.WriteNumberValue(value.c0.y);

        writer.WriteNumberValue(value.c0.z);

        writer.WriteNumberValue(value.c0.w);

        writer.WriteNumberValue(value.c1.x);

        writer.WriteNumberValue(value.c1.y);

        writer.WriteNumberValue(value.c1.z);

        writer.WriteNumberValue(value.c1.w);

        writer.WriteEndArray();
    }

    public int4x2 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new int4x2();

        reader.Read();
        value.c0.x = reader.GetInt32("m00");

        reader.Read();
        value.c0.y = reader.GetInt32("m01");

        reader.Read();
        value.c0.z = reader.GetInt32("m02");

        reader.Read();
        value.c0.w = reader.GetInt32("m03");

        reader.Read();
        value.c1.x = reader.GetInt32("m10");

        reader.Read();
        value.c1.y = reader.GetInt32("m11");

        reader.Read();
        value.c1.z = reader.GetInt32("m12");

        reader.Read();
        value.c1.w = reader.GetInt32("m13");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, int4x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("m00", value.c0.x);

        writer.WriteNumber("m01", value.c0.y);

        writer.WriteNumber("m02", value.c0.z);

        writer.WriteNumber("m03", value.c0.w);

        writer.WriteNumber("m10", value.c1.x);

        writer.WriteNumber("m11", value.c1.y);

        writer.WriteNumber("m12", value.c1.z);

        writer.WriteNumber("m13", value.c1.w);

        writer.WriteEndObject();
    }

    public int4x2 ReadCompatible(
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

    public Int4x2JsonConverter(
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

    public override int4x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) => readFunc(ref reader, typeToConvert, options);

    public override void Write(
        Utf8JsonWriter writer,
        int4x2 value,
        JsonSerializerOptions options
    ) => writeFunc(writer, value, options);
}
