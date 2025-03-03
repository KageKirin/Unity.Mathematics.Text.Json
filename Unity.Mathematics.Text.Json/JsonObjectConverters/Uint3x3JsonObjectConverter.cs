using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x3JsonObjectConverter : Uint3x3JsonConverter
{
    public Uint3x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
