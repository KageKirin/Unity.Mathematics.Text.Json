
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public abstract class Bool4x2JsonConverter : JsonConverter<bool4x2>

{

    public delegate bool4x2 ReadFunc(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

    public delegate void WriteFunc(Utf8JsonWriter writer, bool4x2 value, JsonSerializerOptions options);

    public bool4x2 ReadAsArray(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var value = new bool4x2();
        
        reader.Read();
        value.c0.x = reader.GetBoolean();
        
        reader.Read();
        value.c0.y = reader.GetBoolean();
        
        reader.Read();
        value.c0.z = reader.GetBoolean();
        
        reader.Read();
        value.c0.w = reader.GetBoolean();
        
        reader.Read();
        value.c1.x = reader.GetBoolean();
        
        reader.Read();
        value.c1.y = reader.GetBoolean();
        
        reader.Read();
        value.c1.z = reader.GetBoolean();
        
        reader.Read();
        value.c1.w = reader.GetBoolean();
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndArray)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsArray(Utf8JsonWriter writer, bool4x2 value, JsonSerializerOptions options)

    {

        writer.WriteStartArray();
        
        writer.WriteBooleanValue(value.c0.x);
        
        writer.WriteBooleanValue(value.c0.y);
        
        writer.WriteBooleanValue(value.c0.z);
        
        writer.WriteBooleanValue(value.c0.w);
        
        writer.WriteBooleanValue(value.c1.x);
        
        writer.WriteBooleanValue(value.c1.y);
        
        writer.WriteBooleanValue(value.c1.z);
        
        writer.WriteBooleanValue(value.c1.w);
        
        writer.WriteEndArray();

    }


    public bool4x2 ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new bool4x2();
        
        reader.Read();
        value.c0.x = reader.GetBoolean("m00");
        
        reader.Read();
        value.c0.y = reader.GetBoolean("m01");
        
        reader.Read();
        value.c0.z = reader.GetBoolean("m02");
        
        reader.Read();
        value.c0.w = reader.GetBoolean("m03");
        
        reader.Read();
        value.c1.x = reader.GetBoolean("m10");
        
        reader.Read();
        value.c1.y = reader.GetBoolean("m11");
        
        reader.Read();
        value.c1.z = reader.GetBoolean("m12");
        
        reader.Read();
        value.c1.w = reader.GetBoolean("m13");
        

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public void WriteAsObject(Utf8JsonWriter writer, bool4x2 value, JsonSerializerOptions options)

    {

        writer.WriteStartObject();
        
        writer.WriteBoolean("m00", value.c0.x);
        
        writer.WriteBoolean("m01", value.c0.y);
        
        writer.WriteBoolean("m02", value.c0.z);
        
        writer.WriteBoolean("m03", value.c0.w);
        
        writer.WriteBoolean("m10", value.c1.x);
        
        writer.WriteBoolean("m11", value.c1.y);
        
        writer.WriteBoolean("m12", value.c1.z);
        
        writer.WriteBoolean("m13", value.c1.w);
        
        writer.WriteEndObject();

    }

    public bool4x2 ReadCompatible(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)

    =>
         reader.TokenType switch
        {
            JsonTokenType.StartArray => ReadAsArray(ref reader, typeToConvert, options),
            JsonTokenType.StartObject => ReadAsObject(ref reader, typeToConvert, options),
            _ => throw new JsonException(),
        };
    

    private readonly ReadFunc readFunc;
    private readonly WriteFunc writeFunc;

    public Bool4x2JsonConverter(JsonTokenType readerTokenType = JsonTokenType.None, JsonTokenType writerTokenType = JsonTokenType.None) : base()

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


    public override bool4x2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => readFunc(ref reader, typeToConvert, options);

    public override void Write(Utf8JsonWriter writer, bool4x2 value, JsonSerializerOptions options)
        => writeFunc(writer, value, options);

}

