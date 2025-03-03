using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x4JsonArrayConverter : Uint3x4JsonConverter
{
    public Uint3x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
