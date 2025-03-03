using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x4JsonArrayConverter : Float4x4JsonConverter
{
    public Float4x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
