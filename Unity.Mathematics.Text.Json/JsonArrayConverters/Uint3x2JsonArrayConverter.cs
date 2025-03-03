using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x2JsonArrayConverter : Uint3x2JsonConverter
{
    public Uint3x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
