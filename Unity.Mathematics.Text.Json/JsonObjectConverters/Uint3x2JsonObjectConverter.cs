using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x2JsonObjectConverter : Uint3x2JsonConverter
{
    public Uint3x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
