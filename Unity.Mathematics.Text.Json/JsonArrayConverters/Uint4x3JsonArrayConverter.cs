using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x3JsonArrayConverter : Uint4x3JsonConverter
{
    public Uint4x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
