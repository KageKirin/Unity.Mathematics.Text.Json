using System.Text.Json;
using Unity.Mathematics.Text.Json.ArrayNotation;

namespace Unity.Mathematics.Text.Json;

public static class Profile
{
    public static readonly JsonSerializerOptions JsonSerializerOptions =
        new()
        {
            MaxDepth = 1024,
            WriteIndented = true,
            Converters =
            {
                new Float2JsonConverter(),
                new Float3JsonConverter(),
                new Float4JsonConverter(),
                new QuaternionJsonConverter(),
                new Float2x2JsonConverter(),
                new Float2x3JsonConverter(),
                new Float2x4JsonConverter(),
                new Float3x2JsonConverter(),
                new Float3x3JsonConverter(),
                new Float3x4JsonConverter(),
                new Float4x2JsonConverter(),
                new Float4x3JsonConverter(),
                new Float4x4JsonConverter(),
                new Int2JsonConverter(),
                new Int3JsonConverter(),
                new Int4JsonConverter(),
                new Int2x2JsonConverter(),
                new Int2x3JsonConverter(),
                new Int2x4JsonConverter(),
                new Int3x2JsonConverter(),
                new Int3x3JsonConverter(),
                new Int3x4JsonConverter(),
                new Int4x2JsonConverter(),
                new Int4x3JsonConverter(),
                new Int4x4JsonConverter(),
                new Uint2JsonConverter(),
                new Uint3JsonConverter(),
                new Uint4JsonConverter(),
                new Uint2x2JsonConverter(),
                new Uint2x3JsonConverter(),
                new Uint2x4JsonConverter(),
                new Uint3x2JsonConverter(),
                new Uint3x3JsonConverter(),
                new Uint3x4JsonConverter(),
                new Uint4x2JsonConverter(),
                new Uint4x3JsonConverter(),
                new Uint4x4JsonConverter(),
                new Double2JsonConverter(),
                new Double3JsonConverter(),
                new Double4JsonConverter(),
                new Double2x2JsonConverter(),
                new Double2x3JsonConverter(),
                new Double2x4JsonConverter(),
                new Double3x2JsonConverter(),
                new Double3x3JsonConverter(),
                new Double3x4JsonConverter(),
                new Double4x2JsonConverter(),
                new Double4x3JsonConverter(),
                new Double4x4JsonConverter(),
                new Bool2JsonConverter(),
                new Bool3JsonConverter(),
                new Bool4JsonConverter(),
                new Bool2x2JsonConverter(),
                new Bool2x3JsonConverter(),
                new Bool2x4JsonConverter(),
                new Bool3x2JsonConverter(),
                new Bool3x3JsonConverter(),
                new Bool3x4JsonConverter(),
                new Bool4x2JsonConverter(),
                new Bool4x3JsonConverter(),
                new Bool4x4JsonConverter()
            }
        };
}
