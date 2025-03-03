using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class Float2x2JsonConverter : JsonConverter<float2x2>
{
    public delegate float2x2 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        float2x2 value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Float2x2JsonConverter(
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

    public override float2x2 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return readFunc(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, float2x2 value, JsonSerializerOptions options)
    {
        writeFunc(writer, value, options);
    }

    public float2x2 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new float2x2();

        reader.Read();
        value.c0.x = (float)reader.GetDouble();

        reader.Read();
        value.c0.y = (float)reader.GetDouble();

        reader.Read();
        value.c1.x = (float)reader.GetDouble();

        reader.Read();
        value.c1.y = (float)reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, float2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.c0.x);
        writer.WriteNumberValue(value.c0.y);
        writer.WriteNumberValue(value.c1.x);
        writer.WriteNumberValue(value.c1.y);
        writer.WriteEndArray();
    }

    public float2x2 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new float2x2();

        reader.Read();
        value.c0.x = (float)reader.GetDouble("m00");

        reader.Read();
        value.c0.y = (float)reader.GetDouble("m01");

        reader.Read();
        value.c1.x = (float)reader.GetDouble("m10");

        reader.Read();
        value.c1.y = (float)reader.GetDouble("m11");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, float2x2 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteNumber("m00", value.c0.x);
        writer.WriteNumber("m01", value.c0.y);
        writer.WriteNumber("m10", value.c1.x);
        writer.WriteNumber("m11", value.c1.y);
        writer.WriteEndObject();
    }

    public float2x2 ReadCompatible(
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
