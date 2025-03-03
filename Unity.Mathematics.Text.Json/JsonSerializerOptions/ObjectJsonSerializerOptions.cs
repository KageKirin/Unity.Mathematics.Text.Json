using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public static class Object
{
    public static readonly JsonSerializerOptions JsonSerializerOptions =
        CreateJsonObjectSerializerOptions();

    private static JsonSerializerOptions CreateJsonObjectSerializerOptions()
    {
        JsonSerializerOptions jsonSerializerOptions =
            new() { MaxDepth = 1024, WriteIndented = true, };

        jsonSerializerOptions.Converters.Add(new Float2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new QuaternionJsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float2x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float2x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float2x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float3x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float3x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float3x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float4x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float4x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Float4x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int2x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int2x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int2x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int3x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int3x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int3x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int4x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int4x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Int4x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double2x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double2x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double2x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double3x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double3x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double3x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double4x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double4x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Double4x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x4JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x2JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x3JsonObjectConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x4JsonObjectConverter());

        return jsonSerializerOptions;
    }
}
