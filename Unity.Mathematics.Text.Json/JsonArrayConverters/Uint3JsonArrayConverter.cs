using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3JsonArrayConverter : Uint3JsonConverter
{
    public Uint3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
