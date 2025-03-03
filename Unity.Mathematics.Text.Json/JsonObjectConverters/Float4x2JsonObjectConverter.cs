using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x2JsonObjectConverter : Float4x2JsonConverter
{
    public Float4x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
