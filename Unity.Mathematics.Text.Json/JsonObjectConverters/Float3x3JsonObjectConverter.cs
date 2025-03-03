using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x3JsonObjectConverter : Float3x3JsonConverter
{
    public Float3x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
