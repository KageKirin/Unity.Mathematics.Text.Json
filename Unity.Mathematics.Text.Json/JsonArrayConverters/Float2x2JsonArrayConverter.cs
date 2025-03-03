using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x2JsonArrayConverter : Float2x2JsonConverter
{
    public Float2x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
