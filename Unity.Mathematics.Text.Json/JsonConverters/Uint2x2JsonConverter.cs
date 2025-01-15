
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Uint2x2JsonConverter : JsonConverter<uint2x2>

{

    public delegate uint2x2 ReadFunc(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

    public delegate void WriteFunc(Utf8JsonWriter writer, uint2x2 value, JsonSerializerOptions options);

    public uint2x2 ReadAsArray(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new uint2x2();
        
        reader.Read();
        value.c0.x = reader.GetUInt32();
        
        reader.Read();
        value.c0.y = reader.GetUInt32();
        
        reader.Read();
        value.c1.x = reader.GetUInt32();
        
        reader.Read();
        value.c1.y = reader.GetUInt32();
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, uint2x2 value, JsonSerializerOptions options)

    {

        writer.WriteStartArray();
        
        writer.WriteNumberValue(value.c0.x);
        
        writer.WriteNumberValue(value.c0.y);
        
        writer.WriteNumberValue(value.c1.x);
        
        writer.WriteNumberValue(value.c1.y);
        
        writer.WriteEndArray();

    }


    public uint2x2 ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new uint2x2();
        
        reader.Read();
        value.c0.x = reader.GetUInt32("m00");
        
        reader.Read();
        value.c0.y = reader.GetUInt32("m01");
        
        reader.Read();
        value.c1.x = reader.GetUInt32("m10");
        
        reader.Read();
        value.c1.y = reader.GetUInt32("m11");
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, uint2x2 value, JsonSerializerOptions options)

    {

        writer.WriteStartObject();
        
        writer.WriteNumber("m00", value.c0.x);
        
        writer.WriteNumber("m01", value.c0.y);
        
        writer.WriteNumber("m10", value.c1.x);
        
        writer.WriteNumber("m11", value.c1.y);
        
        writer.WriteEndObject();

    }

    public uint2x2 ReadCompatible(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    =>
         reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException(),
        };
    

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Uint2x2JsonConverter(JsonTokenType readerTokenType = JsonTokenType.None, JsonTokenType writerTokenType = JsonTokenType.None) : base()

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


    public override uint2x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, uint2x2 value, JsonSerializerOptions options)
        => writeFunc(writer, value, options);

}

