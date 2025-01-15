
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Float3x2JsonConverter : JsonConverter<float3x2>

{

    public delegate float3x2 ReadFunc(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

    public delegate void WriteFunc(Utf8JsonWriter writer, float3x2 value, JsonSerializerOptions options);

    public float3x2 ReadAsArray(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new float3x2();
        
        reader.Read();
        value.c0.x = (float)reader.GetDouble();
        
        reader.Read();
        value.c0.y = (float)reader.GetDouble();
        
        reader.Read();
        value.c0.z = (float)reader.GetDouble();
        
        reader.Read();
        value.c1.x = (float)reader.GetDouble();
        
        reader.Read();
        value.c1.y = (float)reader.GetDouble();
        
        reader.Read();
        value.c1.z = (float)reader.GetDouble();
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, float3x2 value, JsonSerializerOptions options)

    {

        writer.WriteStartArray();
        
        writer.WriteNumberValue(value.c0.x);
        
        writer.WriteNumberValue(value.c0.y);
        
        writer.WriteNumberValue(value.c0.z);
        
        writer.WriteNumberValue(value.c1.x);
        
        writer.WriteNumberValue(value.c1.y);
        
        writer.WriteNumberValue(value.c1.z);
        
        writer.WriteEndArray();

    }


    public float3x2 ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new float3x2();
        
        reader.Read();
        value.c0.x = (float)reader.GetDouble("m00");
        
        reader.Read();
        value.c0.y = (float)reader.GetDouble("m01");
        
        reader.Read();
        value.c0.z = (float)reader.GetDouble("m02");
        
        reader.Read();
        value.c1.x = (float)reader.GetDouble("m10");
        
        reader.Read();
        value.c1.y = (float)reader.GetDouble("m11");
        
        reader.Read();
        value.c1.z = (float)reader.GetDouble("m12");
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, float3x2 value, JsonSerializerOptions options)

    {

        writer.WriteStartObject();
        
        writer.WriteNumber("m00", value.c0.x);
        
        writer.WriteNumber("m01", value.c0.y);
        
        writer.WriteNumber("m02", value.c0.z);
        
        writer.WriteNumber("m10", value.c1.x);
        
        writer.WriteNumber("m11", value.c1.y);
        
        writer.WriteNumber("m12", value.c1.z);
        
        writer.WriteEndObject();

    }

    public float3x2 ReadCompatible(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    =>
         reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException(),
        };
    

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Float3x2JsonConverter(JsonTokenType readerTokenType = JsonTokenType.None, JsonTokenType writerTokenType = JsonTokenType.None) : base()

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


    public override float3x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, float3x2 value, JsonSerializerOptions options)
        => writeFunc(writer, value, options);

}

