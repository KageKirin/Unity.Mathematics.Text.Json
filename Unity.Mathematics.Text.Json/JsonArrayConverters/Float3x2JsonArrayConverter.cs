using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x2JsonArrayConverter : Float3x2JsonConverter
{
    public Float3x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
