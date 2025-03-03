using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2JsonObjectConverter : Float2JsonConverter
{
    public Float2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
