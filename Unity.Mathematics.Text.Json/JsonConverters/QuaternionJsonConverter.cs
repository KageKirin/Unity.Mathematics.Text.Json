using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class QuaternionJsonConverter : JsonConverter<quaternion>
{
    public delegate quaternion ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        quaternion value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public QuaternionJsonConverter(
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

    public override quaternion Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return readFunc(ref reader, typeToConvert, options);
    }

    public override void Write(
        Utf8JsonWriter writer,
        quaternion value,
        JsonSerializerOptions options
    )
    {
        writeFunc(writer, value, options);
    }

    public quaternion ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

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
            throw new JsonException();

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, quaternion value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.value.x);
        writer.WriteNumberValue(value.value.y);
        writer.WriteNumberValue(value.value.z);
        writer.WriteNumberValue(value.value.w);
        writer.WriteEndArray();
    }

    public quaternion ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new quaternion();

        reader.Read();
        value.value.x = (float)reader.GetDouble("x");

        reader.Read();
        value.value.y = (float)reader.GetDouble("y");

        reader.Read();
        value.value.z = (float)reader.GetDouble("z");

        reader.Read();
        value.value.w = (float)reader.GetDouble("w");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public void WriteAsObject(
        Utf8JsonWriter writer,
        quaternion value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartObject();
        writer.WriteNumber("x", value.value.x);
        writer.WriteNumber("y", value.value.y);
        writer.WriteNumber("z", value.value.z);
        writer.WriteNumber("w", value.value.w);
        writer.WriteEndObject();
    }

    public quaternion ReadCompatible(
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
