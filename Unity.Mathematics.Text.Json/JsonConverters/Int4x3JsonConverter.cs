using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class Int4x3JsonConverter : JsonConverter<int4x3>
{
    public delegate int4x3 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        int4x3 value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Int4x3JsonConverter(
        JsonTokenType readerTokenType = JsonTokenType.None,
        JsonTokenType writerTokenType = JsonTokenType.None
    )
    {
        readFunc = readerTokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray,
            JsonTokenType.StartObject => ReadAsObject,
            _ => ReadCompatible
        };

        writeFunc = writerTokenType switch
        {
            JsonTokenType.StartArray => WriteAsArray,
            JsonTokenType.StartObject => WriteAsObject,
            _ => WriteAsArray //!< we need _some_ kind of default
        };
    }

    public override int4x3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return readFunc(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, int4x3 value, JsonSerializerOptions options)
    {
        writeFunc(writer, value, options);
    }

    public int4x3 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new int4x3();

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
        value.c2.x = reader.GetInt32();

        reader.Read();
        value.c2.y = reader.GetInt32();

        reader.Read();
        value.c2.z = reader.GetInt32();

        reader.Read();
        value.c2.w = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, int4x3 value, JsonSerializerOptions options)
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
        writer.WriteNumberValue(value.c2.x);
        writer.WriteNumberValue(value.c2.y);
        writer.WriteNumberValue(value.c2.z);
        writer.WriteNumberValue(value.c2.w);
        writer.WriteEndArray();
    }

    public int4x3 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new int4x3();

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
        value.c2.x = reader.GetInt32("m20");

        reader.Read();
        value.c2.y = reader.GetInt32("m21");

        reader.Read();
        value.c2.z = reader.GetInt32("m22");

        reader.Read();
        value.c2.w = reader.GetInt32("m23");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, int4x3 value, JsonSerializerOptions options)
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
        writer.WriteNumber("m20", value.c2.x);
        writer.WriteNumber("m21", value.c2.y);
        writer.WriteNumber("m22", value.c2.z);
        writer.WriteNumber("m23", value.c2.w);
        writer.WriteEndObject();
    }

    public int4x3 ReadCompatible(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException()
        };
    }
}
