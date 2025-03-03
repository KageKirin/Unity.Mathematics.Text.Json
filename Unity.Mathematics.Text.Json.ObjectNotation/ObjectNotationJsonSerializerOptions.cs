using System.Text.Json;
using Unity.Mathematics.Text.Json.ObjectNotation;

namespace Unity.Mathematics.Text.Json;

public static class Profile
{
    public static readonly JsonSerializerOptions JsonSerializerOptions =
        CreateJsonSerializerOptions();

    private static JsonSerializerOptions CreateJsonSerializerOptions()
    {
        JsonSerializerOptions jsonSerializerOptions =
            new() { MaxDepth = 1024, WriteIndented = true, };

        jsonSerializerOptions.Converters.Add(new Float2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float4JsonConverter());
        jsonSerializerOptions.Converters.Add(new QuaternionJsonConverter());
        jsonSerializerOptions.Converters.Add(new Float2x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float2x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float2x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float3x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float3x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float3x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float4x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float4x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Float4x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int2x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int2x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int2x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int3x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int3x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int3x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int4x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int4x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Int4x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint2x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint3x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Uint4x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double2x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double2x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double2x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double3x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double3x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double3x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double4x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double4x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Double4x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool2x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool3x4JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x2JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x3JsonConverter());
        jsonSerializerOptions.Converters.Add(new Bool4x4JsonConverter());

        return jsonSerializerOptions;
    }
}
