
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Double3JsonConverter : JsonConverter<double3>

{

    public delegate double3 ReadFunc(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

    public delegate void WriteFunc(Utf8JsonWriter writer, double3 value, JsonSerializerOptions options);

    public double3 ReadAsArray(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new double3();
        
        reader.Read();
        value.x = reader.GetDouble();
        
        reader.Read();
        value.y = reader.GetDouble();
        
        reader.Read();
        value.z = reader.GetDouble();
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, double3 value, JsonSerializerOptions options)

    {

        writer.WriteStartArray();
        
        writer.WriteNumberValue(value.x);
        
        writer.WriteNumberValue(value.y);
        
        writer.WriteNumberValue(value.z);
        
        writer.WriteEndArray();

    }


    public double3 ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new double3();
        
        reader.Read();
        value.x = reader.GetDouble("x");
        
        reader.Read();
        value.y = reader.GetDouble("y");
        
        reader.Read();
        value.z = reader.GetDouble("z");
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, double3 value, JsonSerializerOptions options)

    {

        writer.WriteStartObject();
        
        writer.WriteNumber("x", value.x);
        
        writer.WriteNumber("y", value.y);
        
        writer.WriteNumber("z", value.z);
        
        writer.WriteEndObject();

    }

    public double3 ReadCompatible(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    =>
         reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException(),
        };
    

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Double3JsonConverter(JsonTokenType readerTokenType = JsonTokenType.None, JsonTokenType writerTokenType = JsonTokenType.None) : base()

    {

        readFunc = readerTokenType switch {
            JsonTokenType.StartArray => ReadAsArray,
            JsonTokenType.StartObject => ReadAsObject,
            _ => ReadCompatible,
        };

        writeFunc = writerTokenType switch {
            JsonTokenType.StartArray => WriteAsArray,
            JsonTokenType.StartObject => WriteAsObject,
            _ => WriteAsArray, //!< we need _some_ kind of default
        };

    }


    public override double3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, double3 value, JsonSerializerOptions options)
        => writeFunc(writer, value, options);

}

