using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x4JsonObjectConverter : Float4x4JsonConverter
{
    public Float4x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
