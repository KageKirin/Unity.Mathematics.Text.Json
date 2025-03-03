using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4JsonObjectConverter : Float4JsonConverter
{
    public Float4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
