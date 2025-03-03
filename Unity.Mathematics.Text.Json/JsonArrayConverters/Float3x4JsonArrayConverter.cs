using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x4JsonArrayConverter : Float3x4JsonConverter
{
    public Float3x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
