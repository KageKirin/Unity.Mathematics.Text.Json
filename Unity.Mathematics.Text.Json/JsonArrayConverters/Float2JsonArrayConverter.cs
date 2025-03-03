using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2JsonArrayConverter : Float2JsonConverter
{
    public Float2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
