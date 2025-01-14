using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public static class Object
{
    public static JsonSerializerOptions JsonSerializerOptions =
        new()
        {
            MaxDepth = 1024,
            WriteIndented = true,
            Converters =
            {
                new Float2JsonObjectConverter(),
                new Float3JsonObjectConverter(),
                new Float4JsonObjectConverter(),
                new QuaternionJsonObjectConverter(),
                new Float2x2JsonObjectConverter(),
                new Float2x3JsonObjectConverter(),
                new Float2x4JsonObjectConverter(),
                new Float3x2JsonObjectConverter(),
                new Float3x3JsonObjectConverter(),
                new Float3x4JsonObjectConverter(),
                new Float4x2JsonObjectConverter(),
                new Float4x3JsonObjectConverter(),
                new Float4x4JsonObjectConverter(),
                new Int2JsonObjectConverter(),
                new Int3JsonObjectConverter(),
                new Int4JsonObjectConverter(),
                new Int2x2JsonObjectConverter(),
                new Int2x3JsonObjectConverter(),
                new Int2x4JsonObjectConverter(),
                new Int3x2JsonObjectConverter(),
                new Int3x3JsonObjectConverter(),
                new Int3x4JsonObjectConverter(),
                new Int4x2JsonObjectConverter(),
                new Int4x3JsonObjectConverter(),
                new Int4x4JsonObjectConverter(),
                new Uint2JsonObjectConverter(),
                new Uint3JsonObjectConverter(),
                new Uint4JsonObjectConverter(),
                new Uint2x2JsonObjectConverter(),
                new Uint2x3JsonObjectConverter(),
                new Uint2x4JsonObjectConverter(),
                new Uint3x2JsonObjectConverter(),
                new Uint3x3JsonObjectConverter(),
                new Uint3x4JsonObjectConverter(),
                new Uint4x2JsonObjectConverter(),
                new Uint4x3JsonObjectConverter(),
                new Uint4x4JsonObjectConverter(),
                new Double2JsonObjectConverter(),
                new Double3JsonObjectConverter(),
                new Double4JsonObjectConverter(),
                new Double2x2JsonObjectConverter(),
                new Double2x3JsonObjectConverter(),
                new Double2x4JsonObjectConverter(),
                new Double3x2JsonObjectConverter(),
                new Double3x3JsonObjectConverter(),
                new Double3x4JsonObjectConverter(),
                new Double4x2JsonObjectConverter(),
                new Double4x3JsonObjectConverter(),
                new Double4x4JsonObjectConverter(),
                new Bool2JsonObjectConverter(),
                new Bool3JsonObjectConverter(),
                new Bool4JsonObjectConverter(),
                new Bool2x2JsonObjectConverter(),
                new Bool2x3JsonObjectConverter(),
                new Bool2x4JsonObjectConverter(),
                new Bool3x2JsonObjectConverter(),
                new Bool3x3JsonObjectConverter(),
                new Bool3x4JsonObjectConverter(),
                new Bool4x2JsonObjectConverter(),
                new Bool4x3JsonObjectConverter(),
                new Bool4x4JsonObjectConverter(),
            }
        };
}
