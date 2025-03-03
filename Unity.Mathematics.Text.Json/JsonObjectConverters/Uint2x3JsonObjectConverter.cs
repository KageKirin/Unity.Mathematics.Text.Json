using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x3JsonObjectConverter : Uint2x3JsonConverter
{
    public Uint2x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
