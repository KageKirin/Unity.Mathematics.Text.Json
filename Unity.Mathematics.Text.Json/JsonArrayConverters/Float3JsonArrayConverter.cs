using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3JsonArrayConverter : Float3JsonConverter
{
    public Float3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
