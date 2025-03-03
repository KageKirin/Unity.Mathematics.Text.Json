using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2JsonArrayConverter : Uint2JsonConverter
{
    public Uint2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
