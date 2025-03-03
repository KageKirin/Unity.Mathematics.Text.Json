using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public static class Array
{
    public static readonly JsonSerializerOptions JsonSerializerOptions =
        CreateJsonArraySerializerOptions();

    private static JsonSerializerOptions CreateJsonArraySerializerOptions()
    {
        JsonSerializerOptions jsonSerializerOptions =
            new() { MaxDepth = 1024, WriteIndented = true, };

        jsonSerializerOptions.Converters.Add(new Float2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new QuaternionJsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float2x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float2x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float2x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float3x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float3x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float3x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float4x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float4x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Float4x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int2x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int2x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int2x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int3x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int3x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int3x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int4x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int4x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Int4x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double2x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double2x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double2x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double3x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double3x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double3x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double4x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double4x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Double4x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x4JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x2JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x3JsonArrayConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x4JsonArrayConverter());

        return jsonSerializerOptions;
    }
}
