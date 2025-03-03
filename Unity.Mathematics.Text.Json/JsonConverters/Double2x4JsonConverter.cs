using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json;

public class Double2x4JsonConverter : JsonConverter<double2x4>
{
    public delegate double2x4 ReadFunc(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    );

    public delegate void WriteFunc(
        Utf8JsonWriter writer,
        double2x4 value,
        JsonSerializerOptions options
    );

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Double2x4JsonConverter(
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

    public override double2x4 Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return readFunc(ref reader, typeToConvert, options);
    }

    public override void Write(
        Utf8JsonWriter writer,
        double2x4 value,
        JsonSerializerOptions options
    )
    {
        writeFunc(writer, value, options);
    }

    public double2x4 ReadAsArray(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        var value = new double2x4();

        reader.Read();
        value.c0.x = reader.GetDouble();

        reader.Read();
        value.c0.y = reader.GetDouble();

        reader.Read();
        value.c1.x = reader.GetDouble();

        reader.Read();
        value.c1.y = reader.GetDouble();

        reader.Read();
        value.c2.x = reader.GetDouble();

        reader.Read();
        value.c2.y = reader.GetDouble();

        reader.Read();
        value.c3.x = reader.GetDouble();

        reader.Read();
        value.c3.y = reader.GetDouble();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, double2x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteNumberValue(value.c0.x);
        writer.WriteNumberValue(value.c0.y);
        writer.WriteNumberValue(value.c1.x);
        writer.WriteNumberValue(value.c1.y);
        writer.WriteNumberValue(value.c2.x);
        writer.WriteNumberValue(value.c2.y);
        writer.WriteNumberValue(value.c3.x);
        writer.WriteNumberValue(value.c3.y);
        writer.WriteEndArray();
    }

    public double2x4 ReadAsObject(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var value = new double2x4();

        reader.Read();
        value.c0.x = reader.GetDouble("m00");

        reader.Read();
        value.c0.y = reader.GetDouble("m01");

        reader.Read();
        value.c1.x = reader.GetDouble("m10");

        reader.Read();
        value.c1.y = reader.GetDouble("m11");

        reader.Read();
        value.c2.x = reader.GetDouble("m20");

        reader.Read();
        value.c2.y = reader.GetDouble("m21");

        reader.Read();
        value.c3.x = reader.GetDouble("m30");

        reader.Read();
        value.c3.y = reader.GetDouble("m31");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, double2x4 value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteNumber("m00", value.c0.x);
        writer.WriteNumber("m01", value.c0.y);
        writer.WriteNumber("m10", value.c1.x);
        writer.WriteNumber("m11", value.c1.y);
        writer.WriteNumber("m20", value.c2.x);
        writer.WriteNumber("m21", value.c2.y);
        writer.WriteNumber("m30", value.c3.x);
        writer.WriteNumber("m31", value.c3.y);
        writer.WriteEndObject();
    }

    public double2x4 ReadCompatible(
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
