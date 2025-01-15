using System;
using System.Collections.Generic;
using System.Text.Json;
using Unity.Mathematics;
using Unity.Mathematics.Text.Json;
using Unity.Mathematics.Text.Json.ArrayNotation;
using Xunit;

#nullable enable

namespace Unity.Mathematics.Text.Json.ArrayNotation.Tests;

public class Float2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2(x: 1, y: 2);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3(x: 1, y: 2, z: 3);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4(x: 1, y: 2, z: 3, w: 4);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float2x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2x2(c0: math.float2(x: 1, y: 2), c1: math.float2(x: 3, y: 4));
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3x2(
            c0: math.float3(x: 1, y: 2, z: 3),
            c1: math.float3(x: 4, y: 5, z: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4x2(
            c0: math.float4(x: 1, y: 2, z: 3, w: 4),
            c1: math.float4(x: 5, y: 6, z: 7, w: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float2x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2x3(
            c0: math.float2(x: 1, y: 2),
            c1: math.float2(x: 3, y: 4),
            c2: math.float2(x: 5, y: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3x3(
            c0: math.float3(x: 1, y: 2, z: 3),
            c1: math.float3(x: 4, y: 5, z: 6),
            c2: math.float3(x: 7, y: 8, z: 9)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4x3(
            c0: math.float4(x: 1, y: 2, z: 3, w: 4),
            c1: math.float4(x: 5, y: 6, z: 7, w: 8),
            c2: math.float4(x: 9, y: 10, z: 11, w: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float2x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float2x4(
            c0: math.float2(x: 1, y: 2),
            c1: math.float2(x: 3, y: 4),
            c2: math.float2(x: 5, y: 6),
            c3: math.float2(x: 7, y: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float3x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float3x4(
            c0: math.float3(x: 1, y: 2, z: 3),
            c1: math.float3(x: 4, y: 5, z: 6),
            c2: math.float3(x: 7, y: 8, z: 9),
            c3: math.float3(x: 10, y: 11, z: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Float4x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.float4x4(
            c0: math.float4(x: 1, y: 2, z: 3, w: 4),
            c1: math.float4(x: 5, y: 6, z: 7, w: 8),
            c2: math.float4(x: 9, y: 10, z: 11, w: 12),
            c3: math.float4(x: 13, y: 14, z: 15, w: 16)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2(x: 1, y: 2);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3(x: 1, y: 2, z: 3);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4(x: 1, y: 2, z: 3, w: 4);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2x2(c0: math.double2(x: 1, y: 2), c1: math.double2(x: 3, y: 4));
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3x2(
            c0: math.double3(x: 1, y: 2, z: 3),
            c1: math.double3(x: 4, y: 5, z: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4x2(
            c0: math.double4(x: 1, y: 2, z: 3, w: 4),
            c1: math.double4(x: 5, y: 6, z: 7, w: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2x3(
            c0: math.double2(x: 1, y: 2),
            c1: math.double2(x: 3, y: 4),
            c2: math.double2(x: 5, y: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3x3(
            c0: math.double3(x: 1, y: 2, z: 3),
            c1: math.double3(x: 4, y: 5, z: 6),
            c2: math.double3(x: 7, y: 8, z: 9)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4x3(
            c0: math.double4(x: 1, y: 2, z: 3, w: 4),
            c1: math.double4(x: 5, y: 6, z: 7, w: 8),
            c2: math.double4(x: 9, y: 10, z: 11, w: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double2x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double2x4(
            c0: math.double2(x: 1, y: 2),
            c1: math.double2(x: 3, y: 4),
            c2: math.double2(x: 5, y: 6),
            c3: math.double2(x: 7, y: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double3x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double3x4(
            c0: math.double3(x: 1, y: 2, z: 3),
            c1: math.double3(x: 4, y: 5, z: 6),
            c2: math.double3(x: 7, y: 8, z: 9),
            c3: math.double3(x: 10, y: 11, z: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Double4x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.double4x4(
            c0: math.double4(x: 1, y: 2, z: 3, w: 4),
            c1: math.double4(x: 5, y: 6, z: 7, w: 8),
            c2: math.double4(x: 9, y: 10, z: 11, w: 12),
            c3: math.double4(x: 13, y: 14, z: 15, w: 16)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2(x: 1, y: 2);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3(x: 1, y: 2, z: 3);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4(x: 1, y: 2, z: 3, w: 4);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2x2(c0: math.int2(x: 1, y: 2), c1: math.int2(x: 3, y: 4));
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3x2(c0: math.int3(x: 1, y: 2, z: 3), c1: math.int3(x: 4, y: 5, z: 6));
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4x2(
            c0: math.int4(x: 1, y: 2, z: 3, w: 4),
            c1: math.int4(x: 5, y: 6, z: 7, w: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2x3(
            c0: math.int2(x: 1, y: 2),
            c1: math.int2(x: 3, y: 4),
            c2: math.int2(x: 5, y: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3x3(
            c0: math.int3(x: 1, y: 2, z: 3),
            c1: math.int3(x: 4, y: 5, z: 6),
            c2: math.int3(x: 7, y: 8, z: 9)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4x3(
            c0: math.int4(x: 1, y: 2, z: 3, w: 4),
            c1: math.int4(x: 5, y: 6, z: 7, w: 8),
            c2: math.int4(x: 9, y: 10, z: 11, w: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int2x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int2x4(
            c0: math.int2(x: 1, y: 2),
            c1: math.int2(x: 3, y: 4),
            c2: math.int2(x: 5, y: 6),
            c3: math.int2(x: 7, y: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int3x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int3x4(
            c0: math.int3(x: 1, y: 2, z: 3),
            c1: math.int3(x: 4, y: 5, z: 6),
            c2: math.int3(x: 7, y: 8, z: 9),
            c3: math.int3(x: 10, y: 11, z: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Int4x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.int4x4(
            c0: math.int4(x: 1, y: 2, z: 3, w: 4),
            c1: math.int4(x: 5, y: 6, z: 7, w: 8),
            c2: math.int4(x: 9, y: 10, z: 11, w: 12),
            c3: math.int4(x: 13, y: 14, z: 15, w: 16)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2(x: 1, y: 2);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3(x: 1, y: 2, z: 3);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4(x: 1, y: 2, z: 3, w: 4);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2x2(c0: math.uint2(x: 1, y: 2), c1: math.uint2(x: 3, y: 4));
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3x2(
            c0: math.uint3(x: 1, y: 2, z: 3),
            c1: math.uint3(x: 4, y: 5, z: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4x2(
            c0: math.uint4(x: 1, y: 2, z: 3, w: 4),
            c1: math.uint4(x: 5, y: 6, z: 7, w: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2x3(
            c0: math.uint2(x: 1, y: 2),
            c1: math.uint2(x: 3, y: 4),
            c2: math.uint2(x: 5, y: 6)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3x3(
            c0: math.uint3(x: 1, y: 2, z: 3),
            c1: math.uint3(x: 4, y: 5, z: 6),
            c2: math.uint3(x: 7, y: 8, z: 9)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4x3(
            c0: math.uint4(x: 1, y: 2, z: 3, w: 4),
            c1: math.uint4(x: 5, y: 6, z: 7, w: 8),
            c2: math.uint4(x: 9, y: 10, z: 11, w: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt2x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint2x4(
            c0: math.uint2(x: 1, y: 2),
            c1: math.uint2(x: 3, y: 4),
            c2: math.uint2(x: 5, y: 6),
            c3: math.uint2(x: 7, y: 8)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt3x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint3x4(
            c0: math.uint3(x: 1, y: 2, z: 3),
            c1: math.uint3(x: 4, y: 5, z: 6),
            c2: math.uint3(x: 7, y: 8, z: 9),
            c3: math.uint3(x: 10, y: 11, z: 12)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class UInt4x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.uint4x4(
            c0: math.uint4(x: 1, y: 2, z: 3, w: 4),
            c1: math.uint4(x: 5, y: 6, z: 7, w: 8),
            c2: math.uint4(x: 9, y: 10, z: 11, w: 12),
            c3: math.uint4(x: 13, y: 14, z: 15, w: 16)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2(x: true, y: false);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3(x: true, y: false, z: true);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4(x: true, y: false, z: true, w: false);
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2x2(
            c0: math.bool2(x: true, y: false),
            c1: math.bool2(x: true, y: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3x2(
            c0: math.bool3(x: true, y: false, z: true),
            c1: math.bool3(x: false, y: true, z: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4x2JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4x2(
            c0: math.bool4(x: true, y: false, z: true, w: false),
            c1: math.bool4(x: true, y: false, z: true, w: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x2>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2x3(
            c0: math.bool2(x: true, y: false),
            c1: math.bool2(x: true, y: false),
            c2: math.bool2(x: true, y: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3x3(
            c0: math.bool3(x: true, y: false, z: true),
            c1: math.bool3(x: false, y: true, z: false),
            c2: math.bool3(x: true, y: false, z: true)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4x3JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4x3(
            c0: math.bool4(x: true, y: false, z: true, w: false),
            c1: math.bool4(x: true, y: false, z: true, w: false),
            c2: math.bool4(x: true, y: false, z: true, w: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x3>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool2x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool2x4(
            c0: math.bool2(x: true, y: false),
            c1: math.bool2(x: true, y: false),
            c2: math.bool2(x: true, y: false),
            c3: math.bool2(x: true, y: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool3x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool3x4(
            c0: math.bool3(x: true, y: false, z: true),
            c1: math.bool3(x: false, y: true, z: false),
            c2: math.bool3(x: true, y: false, z: true),
            c3: math.bool3(x: false, y: true, z: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class Bool4x4JsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = math.bool4x4(
            c0: math.bool4(x: true, y: false, z: true, w: false),
            c1: math.bool4(x: true, y: false, z: true, w: false),
            c2: math.bool4(x: true, y: false, z: true, w: false),
            c3: math.bool4(x: true, y: false, z: true, w: false)
        );
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x4>(json, Profile.JsonSerializerOptions);

        Assert.Equal(dataA, dataB);
    }
}

public class ArrayOfFloat2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float2[] { math.float2(x: 1, y: 2), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float3[] { math.float3(x: 1, y: 2, z: 3), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float4[] { math.float4(x: 1, y: 2, z: 3, w: 4), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat2x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float2x2[]
        {
            math.float2x2(c0: math.float2(x: 1, y: 2), c1: math.float2(x: 3, y: 4)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float3x2[]
        {
            math.float3x2(c0: math.float3(x: 1, y: 2, z: 3), c1: math.float3(x: 4, y: 5, z: 6)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float4x2[]
        {
            math.float4x2(
                c0: math.float4(x: 1, y: 2, z: 3, w: 4),
                c1: math.float4(x: 5, y: 6, z: 7, w: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat2x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float2x3[]
        {
            math.float2x3(
                c0: math.float2(x: 1, y: 2),
                c1: math.float2(x: 3, y: 4),
                c2: math.float2(x: 5, y: 6)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float3x3[]
        {
            math.float3x3(
                c0: math.float3(x: 1, y: 2, z: 3),
                c1: math.float3(x: 4, y: 5, z: 6),
                c2: math.float3(x: 7, y: 8, z: 9)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float4x3[]
        {
            math.float4x3(
                c0: math.float4(x: 1, y: 2, z: 3, w: 4),
                c1: math.float4(x: 5, y: 6, z: 7, w: 8),
                c2: math.float4(x: 9, y: 10, z: 11, w: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat2x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float2x4[]
        {
            math.float2x4(
                c0: math.float2(x: 1, y: 2),
                c1: math.float2(x: 3, y: 4),
                c2: math.float2(x: 5, y: 6),
                c3: math.float2(x: 7, y: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float2x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat3x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float3x4[]
        {
            math.float3x4(
                c0: math.float3(x: 1, y: 2, z: 3),
                c1: math.float3(x: 4, y: 5, z: 6),
                c2: math.float3(x: 7, y: 8, z: 9),
                c3: math.float3(x: 10, y: 11, z: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float3x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfFloat4x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new float4x4[]
        {
            math.float4x4(
                c0: math.float4(x: 1, y: 2, z: 3, w: 4),
                c1: math.float4(x: 5, y: 6, z: 7, w: 8),
                c2: math.float4(x: 9, y: 10, z: 11, w: 12),
                c3: math.float4(x: 13, y: 14, z: 15, w: 16)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<float4x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double2[] { math.double2(x: 1, y: 2), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double3[] { math.double3(x: 1, y: 2, z: 3), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double4[] { math.double4(x: 1, y: 2, z: 3, w: 4), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double2x2[]
        {
            math.double2x2(c0: math.double2(x: 1, y: 2), c1: math.double2(x: 3, y: 4)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double3x2[]
        {
            math.double3x2(c0: math.double3(x: 1, y: 2, z: 3), c1: math.double3(x: 4, y: 5, z: 6)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double4x2[]
        {
            math.double4x2(
                c0: math.double4(x: 1, y: 2, z: 3, w: 4),
                c1: math.double4(x: 5, y: 6, z: 7, w: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double2x3[]
        {
            math.double2x3(
                c0: math.double2(x: 1, y: 2),
                c1: math.double2(x: 3, y: 4),
                c2: math.double2(x: 5, y: 6)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double3x3[]
        {
            math.double3x3(
                c0: math.double3(x: 1, y: 2, z: 3),
                c1: math.double3(x: 4, y: 5, z: 6),
                c2: math.double3(x: 7, y: 8, z: 9)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double4x3[]
        {
            math.double4x3(
                c0: math.double4(x: 1, y: 2, z: 3, w: 4),
                c1: math.double4(x: 5, y: 6, z: 7, w: 8),
                c2: math.double4(x: 9, y: 10, z: 11, w: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble2x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double2x4[]
        {
            math.double2x4(
                c0: math.double2(x: 1, y: 2),
                c1: math.double2(x: 3, y: 4),
                c2: math.double2(x: 5, y: 6),
                c3: math.double2(x: 7, y: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double2x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble3x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double3x4[]
        {
            math.double3x4(
                c0: math.double3(x: 1, y: 2, z: 3),
                c1: math.double3(x: 4, y: 5, z: 6),
                c2: math.double3(x: 7, y: 8, z: 9),
                c3: math.double3(x: 10, y: 11, z: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double3x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfDouble4x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new double4x4[]
        {
            math.double4x4(
                c0: math.double4(x: 1, y: 2, z: 3, w: 4),
                c1: math.double4(x: 5, y: 6, z: 7, w: 8),
                c2: math.double4(x: 9, y: 10, z: 11, w: 12),
                c3: math.double4(x: 13, y: 14, z: 15, w: 16)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<double4x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int2[] { math.int2(x: 1, y: 2), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int3[] { math.int3(x: 1, y: 2, z: 3), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int4[] { math.int4(x: 1, y: 2, z: 3, w: 4), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int2x2[]
        {
            math.int2x2(c0: math.int2(x: 1, y: 2), c1: math.int2(x: 3, y: 4)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int3x2[]
        {
            math.int3x2(c0: math.int3(x: 1, y: 2, z: 3), c1: math.int3(x: 4, y: 5, z: 6)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int4x2[]
        {
            math.int4x2(
                c0: math.int4(x: 1, y: 2, z: 3, w: 4),
                c1: math.int4(x: 5, y: 6, z: 7, w: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int2x3[]
        {
            math.int2x3(
                c0: math.int2(x: 1, y: 2),
                c1: math.int2(x: 3, y: 4),
                c2: math.int2(x: 5, y: 6)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int3x3[]
        {
            math.int3x3(
                c0: math.int3(x: 1, y: 2, z: 3),
                c1: math.int3(x: 4, y: 5, z: 6),
                c2: math.int3(x: 7, y: 8, z: 9)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int4x3[]
        {
            math.int4x3(
                c0: math.int4(x: 1, y: 2, z: 3, w: 4),
                c1: math.int4(x: 5, y: 6, z: 7, w: 8),
                c2: math.int4(x: 9, y: 10, z: 11, w: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt2x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int2x4[]
        {
            math.int2x4(
                c0: math.int2(x: 1, y: 2),
                c1: math.int2(x: 3, y: 4),
                c2: math.int2(x: 5, y: 6),
                c3: math.int2(x: 7, y: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int2x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt3x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int3x4[]
        {
            math.int3x4(
                c0: math.int3(x: 1, y: 2, z: 3),
                c1: math.int3(x: 4, y: 5, z: 6),
                c2: math.int3(x: 7, y: 8, z: 9),
                c3: math.int3(x: 10, y: 11, z: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int3x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfInt4x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new int4x4[]
        {
            math.int4x4(
                c0: math.int4(x: 1, y: 2, z: 3, w: 4),
                c1: math.int4(x: 5, y: 6, z: 7, w: 8),
                c2: math.int4(x: 9, y: 10, z: 11, w: 12),
                c3: math.int4(x: 13, y: 14, z: 15, w: 16)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<int4x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint2[] { math.uint2(x: 1, y: 2), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint3[] { math.uint3(x: 1, y: 2, z: 3), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint4[] { math.uint4(x: 1, y: 2, z: 3, w: 4), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint2x2[]
        {
            math.uint2x2(c0: math.uint2(x: 1, y: 2), c1: math.uint2(x: 3, y: 4)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint3x2[]
        {
            math.uint3x2(c0: math.uint3(x: 1, y: 2, z: 3), c1: math.uint3(x: 4, y: 5, z: 6)),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint4x2[]
        {
            math.uint4x2(
                c0: math.uint4(x: 1, y: 2, z: 3, w: 4),
                c1: math.uint4(x: 5, y: 6, z: 7, w: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint2x3[]
        {
            math.uint2x3(
                c0: math.uint2(x: 1, y: 2),
                c1: math.uint2(x: 3, y: 4),
                c2: math.uint2(x: 5, y: 6)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint3x3[]
        {
            math.uint3x3(
                c0: math.uint3(x: 1, y: 2, z: 3),
                c1: math.uint3(x: 4, y: 5, z: 6),
                c2: math.uint3(x: 7, y: 8, z: 9)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint4x3[]
        {
            math.uint4x3(
                c0: math.uint4(x: 1, y: 2, z: 3, w: 4),
                c1: math.uint4(x: 5, y: 6, z: 7, w: 8),
                c2: math.uint4(x: 9, y: 10, z: 11, w: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt2x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint2x4[]
        {
            math.uint2x4(
                c0: math.uint2(x: 1, y: 2),
                c1: math.uint2(x: 3, y: 4),
                c2: math.uint2(x: 5, y: 6),
                c3: math.uint2(x: 7, y: 8)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint2x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt3x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint3x4[]
        {
            math.uint3x4(
                c0: math.uint3(x: 1, y: 2, z: 3),
                c1: math.uint3(x: 4, y: 5, z: 6),
                c2: math.uint3(x: 7, y: 8, z: 9),
                c3: math.uint3(x: 10, y: 11, z: 12)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint3x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfUInt4x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new uint4x4[]
        {
            math.uint4x4(
                c0: math.uint4(x: 1, y: 2, z: 3, w: 4),
                c1: math.uint4(x: 5, y: 6, z: 7, w: 8),
                c2: math.uint4(x: 9, y: 10, z: 11, w: 12),
                c3: math.uint4(x: 13, y: 14, z: 15, w: 16)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<uint4x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool2[] { math.bool2(x: true, y: false), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool3[] { math.bool3(x: true, y: false, z: true), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool4[] { math.bool4(x: true, y: false, z: true, w: false), };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool2x2[]
        {
            math.bool2x2(c0: math.bool2(x: true, y: false), c1: math.bool2(x: true, y: false))
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool3x2[]
        {
            math.bool3x2(
                c0: math.bool3(x: true, y: false, z: true),
                c1: math.bool3(x: false, y: true, z: false)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4x2sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool4x2[]
        {
            math.bool4x2(
                c0: math.bool4(x: true, y: false, z: true, w: false),
                c1: math.bool4(x: true, y: false, z: true, w: false)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x2[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool2x3[]
        {
            math.bool2x3(
                c0: math.bool2(x: true, y: false),
                c1: math.bool2(x: true, y: false),
                c2: math.bool2(x: true, y: false)
            )
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool3x3[]
        {
            math.bool3x3(
                c0: math.bool3(x: true, y: false, z: true),
                c1: math.bool3(x: false, y: true, z: false),
                c2: math.bool3(x: true, y: false, z: true)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4x3sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool4x3[]
        {
            math.bool4x3(
                c0: math.bool4(x: true, y: false, z: true, w: false),
                c1: math.bool4(x: true, y: false, z: true, w: false),
                c2: math.bool4(x: true, y: false, z: true, w: false)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x3[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool2x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool2x4[]
        {
            math.bool2x4(
                c0: math.bool2(x: true, y: false),
                c1: math.bool2(x: true, y: false),
                c2: math.bool2(x: true, y: false),
                c3: math.bool2(x: true, y: false)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool2x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool3x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool3x4[]
        {
            math.bool3x4(
                c0: math.bool3(x: true, y: false, z: true),
                c1: math.bool3(x: false, y: true, z: false),
                c2: math.bool3(x: true, y: false, z: true),
                c3: math.bool3(x: false, y: true, z: false)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool3x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}

public class ArrayOfBool4x4sJsonConverterTest
{
    [Fact]
    public void Test()
    {
        var dataA = new bool4x4[]
        {
            math.bool4x4(
                c0: math.bool4(x: true, y: false, z: true, w: false),
                c1: math.bool4(x: true, y: false, z: true, w: false),
                c2: math.bool4(x: true, y: false, z: true, w: false),
                c3: math.bool4(x: true, y: false, z: true, w: false)
            ),
        };
        var json = JsonSerializer.Serialize(dataA, Profile.JsonSerializerOptions);
        Assert.False(string.IsNullOrEmpty(json));

        var dataB = JsonSerializer.Deserialize<bool4x4[]>(json, Profile.JsonSerializerOptions);
        Assert.NotNull(dataB);
        Assert.NotEmpty(dataB);

        Assert.Equal(dataA[0], dataB[0]);
    }
}
