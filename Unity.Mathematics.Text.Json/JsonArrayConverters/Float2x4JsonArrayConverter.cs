using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x4JsonArrayConverter : Float2x4JsonConverter
{
    public Float2x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
