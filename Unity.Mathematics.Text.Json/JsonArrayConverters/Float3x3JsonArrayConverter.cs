using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x3JsonArrayConverter : Float3x3JsonConverter
{
    public Float3x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
