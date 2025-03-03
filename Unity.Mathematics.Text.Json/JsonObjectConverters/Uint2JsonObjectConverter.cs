using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2JsonObjectConverter : Uint2JsonConverter
{
    public Uint2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
