using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x3JsonArrayConverter : Float4x3JsonConverter
{
    public Float4x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
