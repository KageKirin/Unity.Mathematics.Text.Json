using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x2JsonObjectConverter : Uint2x2JsonConverter
{
    public Uint2x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
