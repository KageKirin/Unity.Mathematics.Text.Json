using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x2JsonObjectConverter : Float2x2JsonConverter
{
    public Float2x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
