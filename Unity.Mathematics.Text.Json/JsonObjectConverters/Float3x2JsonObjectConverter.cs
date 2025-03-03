using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x2JsonObjectConverter : Float3x2JsonConverter
{
    public Float3x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
