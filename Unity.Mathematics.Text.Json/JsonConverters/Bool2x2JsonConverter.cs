using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class Bool2x2JsonConverter : JsonConverter<bool2x2>
{
    public delegate bool2x2 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        bool2x2 value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Bool2x2JsonConverter(
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

    public override bool2x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return readFunc(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, bool2x2 value, JsonSerializerOptions options)
    {
        writeFunc(writer, value, options);
    }

    public bool2x2 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new bool2x2();

        reader.Read();
        value.c0.x = reader.GetBoolean();

        reader.Read();
        value.c0.y = reader.GetBoolean();

        reader.Read();
        value.c1.x = reader.GetBoolean();

        reader.Read();
        value.c1.y = reader.GetBoolean();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, bool2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteBooleanValue(value.c0.x);
        writer.WriteBooleanValue(value.c0.y);
        writer.WriteBooleanValue(value.c1.x);
        writer.WriteBooleanValue(value.c1.y);
        writer.WriteEndArray();
    }

    public bool2x2 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new bool2x2();

        reader.Read();
        value.c0.x = reader.GetBoolean("m00");

        reader.Read();
        value.c0.y = reader.GetBoolean("m01");

        reader.Read();
        value.c1.x = reader.GetBoolean("m10");

        reader.Read();
        value.c1.y = reader.GetBoolean("m11");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, bool2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteBoolean("m00", value.c0.x);
        writer.WriteBoolean("m01", value.c0.y);
        writer.WriteBoolean("m10", value.c1.x);
        writer.WriteBoolean("m11", value.c1.y);
        writer.WriteEndObject();
    }

    public bool2x2 ReadCompatible(
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
