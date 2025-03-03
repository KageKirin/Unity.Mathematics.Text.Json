using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4JsonArrayConverter : Float4JsonConverter
{
    public Float4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
