using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x3JsonObjectConverter : Float4x3JsonConverter
{
    public Float4x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
