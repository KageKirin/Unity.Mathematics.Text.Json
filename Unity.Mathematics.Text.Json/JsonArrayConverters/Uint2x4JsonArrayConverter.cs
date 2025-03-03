using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x4JsonArrayConverter : Uint2x4JsonConverter
{
    public Uint2x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
