using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class Bool3x4JsonConverter : JsonConverter<bool3x4>
{
    public delegate bool3x4 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        bool3x4 value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Bool3x4JsonConverter(
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

    public override bool3x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return readFunc(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, bool3x4 value, JsonSerializerOptions options)
    {
        writeFunc(writer, value, options);
    }

    public bool3x4 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new bool3x4();

        reader.Read();
        value.c0.x = reader.GetBoolean();

        reader.Read();
        value.c0.y = reader.GetBoolean();

        reader.Read();
        value.c0.z = reader.GetBoolean();

        reader.Read();
        value.c1.x = reader.GetBoolean();

        reader.Read();
        value.c1.y = reader.GetBoolean();

        reader.Read();
        value.c1.z = reader.GetBoolean();

        reader.Read();
        value.c2.x = reader.GetBoolean();

        reader.Read();
        value.c2.y = reader.GetBoolean();

        reader.Read();
        value.c2.z = reader.GetBoolean();

        reader.Read();
        value.c3.x = reader.GetBoolean();

        reader.Read();
        value.c3.y = reader.GetBoolean();

        reader.Read();
        value.c3.z = reader.GetBoolean();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, bool3x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteBooleanValue(value.c0.x);
        writer.WriteBooleanValue(value.c0.y);
        writer.WriteBooleanValue(value.c0.z);
        writer.WriteBooleanValue(value.c1.x);
        writer.WriteBooleanValue(value.c1.y);
        writer.WriteBooleanValue(value.c1.z);
        writer.WriteBooleanValue(value.c2.x);
        writer.WriteBooleanValue(value.c2.y);
        writer.WriteBooleanValue(value.c2.z);
        writer.WriteBooleanValue(value.c3.x);
        writer.WriteBooleanValue(value.c3.y);
        writer.WriteBooleanValue(value.c3.z);
        writer.WriteEndArray();
    }

    public bool3x4 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new bool3x4();

        reader.Read();
        value.c0.x = reader.GetBoolean("m00");

        reader.Read();
        value.c0.y = reader.GetBoolean("m01");

        reader.Read();
        value.c0.z = reader.GetBoolean("m02");

        reader.Read();
        value.c1.x = reader.GetBoolean("m10");

        reader.Read();
        value.c1.y = reader.GetBoolean("m11");

        reader.Read();
        value.c1.z = reader.GetBoolean("m12");

        reader.Read();
        value.c2.x = reader.GetBoolean("m20");

        reader.Read();
        value.c2.y = reader.GetBoolean("m21");

        reader.Read();
        value.c2.z = reader.GetBoolean("m22");

        reader.Read();
        value.c3.x = reader.GetBoolean("m30");

        reader.Read();
        value.c3.y = reader.GetBoolean("m31");

        reader.Read();
        value.c3.z = reader.GetBoolean("m32");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, bool3x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteBoolean("m00", value.c0.x);
        writer.WriteBoolean("m01", value.c0.y);
        writer.WriteBoolean("m02", value.c0.z);
        writer.WriteBoolean("m10", value.c1.x);
        writer.WriteBoolean("m11", value.c1.y);
        writer.WriteBoolean("m12", value.c1.z);
        writer.WriteBoolean("m20", value.c2.x);
        writer.WriteBoolean("m21", value.c2.y);
        writer.WriteBoolean("m22", value.c2.z);
        writer.WriteBoolean("m30", value.c3.x);
        writer.WriteBoolean("m31", value.c3.y);
        writer.WriteBoolean("m32", value.c3.z);
        writer.WriteEndObject();
    }

    public bool3x4 ReadCompatible(
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
