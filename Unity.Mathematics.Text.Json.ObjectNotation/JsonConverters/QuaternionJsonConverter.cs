using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unity.Mathematics.Text.Json.ObjectNotation;

public class QuaternionJsonConverter : JsonConverter<quaternion>
{
    public override quaternion Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var value = new quaternion();

        reader.Read();
        value.value.x = (float)reader.GetDouble("x");

        reader.Read();
        value.value.y = (float)reader.GetDouble("y");

        reader.Read();
        value.value.z = (float)reader.GetDouble("z");

        reader.Read();
        value.value.w = (float)reader.GetDouble("w");

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return value;
    }

    public override void Write(
        Utf8JsonWriter writer,
        quaternion value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartObject();

        writer.WriteNumber("x", value.value.x);

        writer.WriteNumber("y", value.value.y);

        writer.WriteNumber("z", value.value.z);

        writer.WriteNumber("w", value.value.w);

        writer.WriteEndObject();
    }
}
