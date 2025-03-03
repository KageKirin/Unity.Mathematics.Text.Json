using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x2JsonArrayConverter : Float4x2JsonConverter
{
    public Float4x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
