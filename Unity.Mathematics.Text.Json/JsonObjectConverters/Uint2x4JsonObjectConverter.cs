using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x4JsonObjectConverter : Uint2x4JsonConverter
{
    public Uint2x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
