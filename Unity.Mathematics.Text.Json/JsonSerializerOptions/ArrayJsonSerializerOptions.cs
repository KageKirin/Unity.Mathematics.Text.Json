using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public static class Array
{
    public static JsonSerializerOptions JsonSerializerOptions =
        new()
        {
            MaxDepth = 1024,
            WriteIndented = true,
            Converters =
            {
                new Float2JsonArrayConverter(),
                new Float3JsonArrayConverter(),
                new Float4JsonArrayConverter(),
                new QuaternionJsonArrayConverter(),
                new Float2x2JsonArrayConverter(),
                new Float2x3JsonArrayConverter(),
                new Float2x4JsonArrayConverter(),
                new Float3x2JsonArrayConverter(),
                new Float3x3JsonArrayConverter(),
                new Float3x4JsonArrayConverter(),
                new Float4x2JsonArrayConverter(),
                new Float4x3JsonArrayConverter(),
                new Float4x4JsonArrayConverter(),
                new Int2JsonArrayConverter(),
                new Int3JsonArrayConverter(),
                new Int4JsonArrayConverter(),
                new Int2x2JsonArrayConverter(),
                new Int2x3JsonArrayConverter(),
                new Int2x4JsonArrayConverter(),
                new Int3x2JsonArrayConverter(),
                new Int3x3JsonArrayConverter(),
                new Int3x4JsonArrayConverter(),
                new Int4x2JsonArrayConverter(),
                new Int4x3JsonArrayConverter(),
                new Int4x4JsonArrayConverter(),
                new Uint2JsonArrayConverter(),
                new Uint3JsonArrayConverter(),
                new Uint4JsonArrayConverter(),
                new Uint2x2JsonArrayConverter(),
                new Uint2x3JsonArrayConverter(),
                new Uint2x4JsonArrayConverter(),
                new Uint3x2JsonArrayConverter(),
                new Uint3x3JsonArrayConverter(),
                new Uint3x4JsonArrayConverter(),
                new Uint4x2JsonArrayConverter(),
                new Uint4x3JsonArrayConverter(),
                new Uint4x4JsonArrayConverter(),
                new Double2JsonArrayConverter(),
                new Double3JsonArrayConverter(),
                new Double4JsonArrayConverter(),
                new Double2x2JsonArrayConverter(),
                new Double2x3JsonArrayConverter(),
                new Double2x4JsonArrayConverter(),
                new Double3x2JsonArrayConverter(),
                new Double3x3JsonArrayConverter(),
                new Double3x4JsonArrayConverter(),
                new Double4x2JsonArrayConverter(),
                new Double4x3JsonArrayConverter(),
                new Double4x4JsonArrayConverter(),
                new Bool2JsonArrayConverter(),
                new Bool3JsonArrayConverter(),
                new Bool4JsonArrayConverter(),
                new Bool2x2JsonArrayConverter(),
                new Bool2x3JsonArrayConverter(),
                new Bool2x4JsonArrayConverter(),
                new Bool3x2JsonArrayConverter(),
                new Bool3x3JsonArrayConverter(),
                new Bool3x4JsonArrayConverter(),
                new Bool4x2JsonArrayConverter(),
                new Bool4x3JsonArrayConverter(),
                new Bool4x4JsonArrayConverter()
            }
        };
}
