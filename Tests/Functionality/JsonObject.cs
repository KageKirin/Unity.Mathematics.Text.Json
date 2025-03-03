using System.Text.Json;
using Xunit;

namespace Unity.Mathematics.Text.Json.JsonObject.Tests;

public class Float2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2(1, 2);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3(1, 2, 3);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4(1, 2, 3, 4);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float2x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2x2(math.float2(1, 2), math.float2(3, 4));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3x2(math.float3(1, 2, 3), math.float3(4, 5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4x2(math.float4(1, 2, 3, 4), math.float4(5, 6, 7, 8));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float2x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2x3(math.float2(1, 2), math.float2(3, 4), math.float2(5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3x3(math.float3(1, 2, 3), math.float3(4, 5, 6), math.float3(7, 8, 9));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4x3(
            math.float4(1, 2, 3, 4),
            math.float4(5, 6, 7, 8),
            math.float4(9, 10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float2x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2x4(
            math.float2(1, 2),
            math.float2(3, 4),
            math.float2(5, 6),
            math.float2(7, 8)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3x4(
            math.float3(1, 2, 3),
            math.float3(4, 5, 6),
            math.float3(7, 8, 9),
            math.float3(10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4x4(
            math.float4(1, 2, 3, 4),
            math.float4(5, 6, 7, 8),
            math.float4(9, 10, 11, 12),
            math.float4(13, 14, 15, 16)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2(1, 2);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3(1, 2, 3);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4(1, 2, 3, 4);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2x2(math.double2(1, 2), math.double2(3, 4));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3x2(math.double3(1, 2, 3), math.double3(4, 5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4x2(math.double4(1, 2, 3, 4), math.double4(5, 6, 7, 8));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2x3(math.double2(1, 2), math.double2(3, 4), math.double2(5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3x3(
            math.double3(1, 2, 3),
            math.double3(4, 5, 6),
            math.double3(7, 8, 9)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4x3(
            math.double4(1, 2, 3, 4),
            math.double4(5, 6, 7, 8),
            math.double4(9, 10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2x4(
            math.double2(1, 2),
            math.double2(3, 4),
            math.double2(5, 6),
            math.double2(7, 8)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3x4(
            math.double3(1, 2, 3),
            math.double3(4, 5, 6),
            math.double3(7, 8, 9),
            math.double3(10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4x4(
            math.double4(1, 2, 3, 4),
            math.double4(5, 6, 7, 8),
            math.double4(9, 10, 11, 12),
            math.double4(13, 14, 15, 16)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2(1, 2);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3(1, 2, 3);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4(1, 2, 3, 4);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2x2(math.int2(1, 2), math.int2(3, 4));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3x2(math.int3(1, 2, 3), math.int3(4, 5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4x2(math.int4(1, 2, 3, 4), math.int4(5, 6, 7, 8));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2x3(math.int2(1, 2), math.int2(3, 4), math.int2(5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3x3(math.int3(1, 2, 3), math.int3(4, 5, 6), math.int3(7, 8, 9));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4x3(
            math.int4(1, 2, 3, 4),
            math.int4(5, 6, 7, 8),
            math.int4(9, 10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2x4(math.int2(1, 2), math.int2(3, 4), math.int2(5, 6), math.int2(7, 8));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3x4(
            math.int3(1, 2, 3),
            math.int3(4, 5, 6),
            math.int3(7, 8, 9),
            math.int3(10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4x4(
            math.int4(1, 2, 3, 4),
            math.int4(5, 6, 7, 8),
            math.int4(9, 10, 11, 12),
            math.int4(13, 14, 15, 16)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2(1, 2);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3(1, 2, 3);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4(1, 2, 3, 4);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2x2(math.uint2(1, 2), math.uint2(3, 4));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3x2(math.uint3(1, 2, 3), math.uint3(4, 5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4x2(math.uint4(1, 2, 3, 4), math.uint4(5, 6, 7, 8));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2x3(math.uint2(1, 2), math.uint2(3, 4), math.uint2(5, 6));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3x3(math.uint3(1, 2, 3), math.uint3(4, 5, 6), math.uint3(7, 8, 9));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4x3(
            math.uint4(1, 2, 3, 4),
            math.uint4(5, 6, 7, 8),
            math.uint4(9, 10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2x4(
            math.uint2(1, 2),
            math.uint2(3, 4),
            math.uint2(5, 6),
            math.uint2(7, 8)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3x4(
            math.uint3(1, 2, 3),
            math.uint3(4, 5, 6),
            math.uint3(7, 8, 9),
            math.uint3(10, 11, 12)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4x4(
            math.uint4(1, 2, 3, 4),
            math.uint4(5, 6, 7, 8),
            math.uint4(9, 10, 11, 12),
            math.uint4(13, 14, 15, 16)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2(true, false);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3(true, false, true);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4(true, false, true, false);
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2x2(math.bool2(true, false), math.bool2(true, false));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3x2(math.bool3(true, false, true), math.bool3(false, true, false));
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4x2JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4x2(
            math.bool4(true, false, true, false),
            math.bool4(true, false, true, false)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x2>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2x3(
            math.bool2(true, false),
            math.bool2(true, false),
            math.bool2(true, false)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3x3(
            math.bool3(true, false, true),
            math.bool3(false, true, false),
            math.bool3(true, false, true)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4x3JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4x3(
            math.bool4(true, false, true, false),
            math.bool4(true, false, true, false),
            math.bool4(true, false, true, false)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x3>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2x4(
            math.bool2(true, false),
            math.bool2(true, false),
            math.bool2(true, false),
            math.bool2(true, false)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3x4(
            math.bool3(true, false, true),
            math.bool3(false, true, false),
            math.bool3(true, false, true),
            math.bool3(false, true, false)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4x4JsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4x4(
            math.bool4(true, false, true, false),
            math.bool4(true, false, true, false),
            math.bool4(true, false, true, false),
            math.bool4(true, false, true, false)
        );
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x4>(json, Object.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class ArrayOfFloat2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.float2(1, 2) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.float3(1, 2, 3) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.float4(1, 2, 3, 4) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat2x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.float2x2(math.float2(1, 2), math.float2(3, 4)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.float3x2(math.float3(1, 2, 3), math.float3(4, 5, 6)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.float4x2(math.float4(1, 2, 3, 4), math.float4(5, 6, 7, 8)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat2x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.float2x3(math.float2(1, 2), math.float2(3, 4), math.float2(5, 6))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.float3x3(math.float3(1, 2, 3), math.float3(4, 5, 6), math.float3(7, 8, 9))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.float4x3(
                math.float4(1, 2, 3, 4),
                math.float4(5, 6, 7, 8),
                math.float4(9, 10, 11, 12)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat2x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.float2x4(
                math.float2(1, 2),
                math.float2(3, 4),
                math.float2(5, 6),
                math.float2(7, 8)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.float3x4(
                math.float3(1, 2, 3),
                math.float3(4, 5, 6),
                math.float3(7, 8, 9),
                math.float3(10, 11, 12)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.float4x4(
                math.float4(1, 2, 3, 4),
                math.float4(5, 6, 7, 8),
                math.float4(9, 10, 11, 12),
                math.float4(13, 14, 15, 16)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.double2(1, 2) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.double3(1, 2, 3) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.double4(1, 2, 3, 4) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.double2x2(math.double2(1, 2), math.double2(3, 4)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.double3x2(math.double3(1, 2, 3), math.double3(4, 5, 6)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.double4x2(math.double4(1, 2, 3, 4), math.double4(5, 6, 7, 8)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.double2x3(math.double2(1, 2), math.double2(3, 4), math.double2(5, 6))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.double3x3(math.double3(1, 2, 3), math.double3(4, 5, 6), math.double3(7, 8, 9))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.double4x3(
                math.double4(1, 2, 3, 4),
                math.double4(5, 6, 7, 8),
                math.double4(9, 10, 11, 12)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.double2x4(
                math.double2(1, 2),
                math.double2(3, 4),
                math.double2(5, 6),
                math.double2(7, 8)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.double3x4(
                math.double3(1, 2, 3),
                math.double3(4, 5, 6),
                math.double3(7, 8, 9),
                math.double3(10, 11, 12)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.double4x4(
                math.double4(1, 2, 3, 4),
                math.double4(5, 6, 7, 8),
                math.double4(9, 10, 11, 12),
                math.double4(13, 14, 15, 16)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int2(1, 2) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int3(1, 2, 3) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int4(1, 2, 3, 4) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int2x2(math.int2(1, 2), math.int2(3, 4)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int3x2(math.int3(1, 2, 3), math.int3(4, 5, 6)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int4x2(math.int4(1, 2, 3, 4), math.int4(5, 6, 7, 8)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.int2x3(math.int2(1, 2), math.int2(3, 4), math.int2(5, 6)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.int3x3(math.int3(1, 2, 3), math.int3(4, 5, 6), math.int3(7, 8, 9))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.int4x3(math.int4(1, 2, 3, 4), math.int4(5, 6, 7, 8), math.int4(9, 10, 11, 12))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.int2x4(math.int2(1, 2), math.int2(3, 4), math.int2(5, 6), math.int2(7, 8))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.int3x4(
                math.int3(1, 2, 3),
                math.int3(4, 5, 6),
                math.int3(7, 8, 9),
                math.int3(10, 11, 12)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.int4x4(
                math.int4(1, 2, 3, 4),
                math.int4(5, 6, 7, 8),
                math.int4(9, 10, 11, 12),
                math.int4(13, 14, 15, 16)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint2(1, 2) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint3(1, 2, 3) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint4(1, 2, 3, 4) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint2x2(math.uint2(1, 2), math.uint2(3, 4)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint3x2(math.uint3(1, 2, 3), math.uint3(4, 5, 6)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint4x2(math.uint4(1, 2, 3, 4), math.uint4(5, 6, 7, 8)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.uint2x3(math.uint2(1, 2), math.uint2(3, 4), math.uint2(5, 6)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.uint3x3(math.uint3(1, 2, 3), math.uint3(4, 5, 6), math.uint3(7, 8, 9))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.uint4x3(math.uint4(1, 2, 3, 4), math.uint4(5, 6, 7, 8), math.uint4(9, 10, 11, 12))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.uint2x4(math.uint2(1, 2), math.uint2(3, 4), math.uint2(5, 6), math.uint2(7, 8))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.uint3x4(
                math.uint3(1, 2, 3),
                math.uint3(4, 5, 6),
                math.uint3(7, 8, 9),
                math.uint3(10, 11, 12)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.uint4x4(
                math.uint4(1, 2, 3, 4),
                math.uint4(5, 6, 7, 8),
                math.uint4(9, 10, 11, 12),
                math.uint4(13, 14, 15, 16)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.bool2(true, false) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.bool3(true, false, true) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.bool4(true, false, true, false) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[] { math.bool2x2(math.bool2(true, false), math.bool2(true, false)) };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool3x2(math.bool3(true, false, true), math.bool3(false, true, false))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4x2sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool4x2(math.bool4(true, false, true, false), math.bool4(true, false, true, false))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x2[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool2x3(math.bool2(true, false), math.bool2(true, false), math.bool2(true, false))
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool3x3(
                math.bool3(true, false, true),
                math.bool3(false, true, false),
                math.bool3(true, false, true)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4x3sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool4x3(
                math.bool4(true, false, true, false),
                math.bool4(true, false, true, false),
                math.bool4(true, false, true, false)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x3[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool2x4(
                math.bool2(true, false),
                math.bool2(true, false),
                math.bool2(true, false),
                math.bool2(true, false)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool3x4(
                math.bool3(true, false, true),
                math.bool3(false, true, false),
                math.bool3(true, false, true),
                math.bool3(false, true, false)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4x4sJsonObjectConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new[]
        {
            math.bool4x4(
                math.bool4(true, false, true, false),
                math.bool4(true, false, true, false),
                math.bool4(true, false, true, false),
                math.bool4(true, false, true, false)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Object.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x4[]>(json, Object.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}
