using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x3JsonArrayConverter : Uint2x3JsonConverter
{
    public Uint2x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
