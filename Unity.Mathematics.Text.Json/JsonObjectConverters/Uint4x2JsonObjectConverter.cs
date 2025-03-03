using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x2JsonObjectConverter : Uint4x2JsonConverter
{
    public Uint4x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
