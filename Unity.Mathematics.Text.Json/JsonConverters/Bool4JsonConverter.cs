
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Bool4JsonConverter : JsonConverter<bool4>

{

    public delegate bool4 ReadFunc(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

    public delegate void WriteFunc(Utf8JsonWriter writer, bool4 value, JsonSerializerOptions options);

    public bool4 ReadAsArray(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new bool4();
        
        reader.Read();
        value.x = reader.GetBoolean();
        
        reader.Read();
        value.y = reader.GetBoolean();
        
        reader.Read();
        value.z = reader.GetBoolean();
        
        reader.Read();
        value.w = reader.GetBoolean();
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, bool4 value, JsonSerializerOptions options)

    {

        writer.WriteStartArray();
        
        writer.WriteBooleanValue(value.x);
        
        writer.WriteBooleanValue(value.y);
        
        writer.WriteBooleanValue(value.z);
        
        writer.WriteBooleanValue(value.w);
        
        writer.WriteEndArray();

    }


    public bool4 ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new bool4();
        
        reader.Read();
        value.x = reader.GetBoolean("x");
        
        reader.Read();
        value.y = reader.GetBoolean("y");
        
        reader.Read();
        value.z = reader.GetBoolean("z");
        
        reader.Read();
        value.w = reader.GetBoolean("w");
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, bool4 value, JsonSerializerOptions options)

    {

        writer.WriteStartObject();
        
        writer.WriteBoolean("x", value.x);
        
        writer.WriteBoolean("y", value.y);
        
        writer.WriteBoolean("z", value.z);
        
        writer.WriteBoolean("w", value.w);
        
        writer.WriteEndObject();

    }

    public bool4 ReadCompatible(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    =>
         reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException(),
        };
    

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Bool4JsonConverter(JsonTokenType readerTokenType = JsonTokenType.None, JsonTokenType writerTokenType = JsonTokenType.None) : base()

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


    public override bool4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, bool4 value, JsonSerializerOptions options)
        => writeFunc(writer, value, options);

}

