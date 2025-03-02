using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class Int3JsonConverter : JsonConverter<int3>
{
    public delegate int3 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );
    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        int3 value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Int3JsonConverter(
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

    public override int3 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, int3 value, JsonSerializerOptions options) =>
        writeFunc(writer, value, options);

    public int3 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new int3();

        reader.Read();
        value.x = reader.GetInt32();

        reader.Read();
        value.y = reader.GetInt32();

        reader.Read();
        value.z = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, int3 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.x);
        writer.WriteNumberValue(value.y);
        writer.WriteNumberValue(value.z);
        writer.WriteEndArray();
    }

    public int3 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new int3();

        reader.Read();
        value.x = reader.GetInt32("x");

        reader.Read();
        value.y = reader.GetInt32("y");

        reader.Read();
        value.z = reader.GetInt32("z");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, int3 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteNumber("x", value.x);
        writer.WriteNumber("y", value.y);
        writer.WriteNumber("z", value.z);
        writer.WriteEndObject();
    }

    public int3 ReadCompatible(
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
}
