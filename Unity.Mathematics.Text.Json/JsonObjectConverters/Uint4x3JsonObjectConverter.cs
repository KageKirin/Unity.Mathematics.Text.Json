using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x3JsonObjectConverter : Uint4x3JsonConverter
{
    public Uint4x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
