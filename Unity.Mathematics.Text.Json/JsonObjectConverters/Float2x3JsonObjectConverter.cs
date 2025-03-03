using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x3JsonObjectConverter : Float2x3JsonConverter
{
    public Float2x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
