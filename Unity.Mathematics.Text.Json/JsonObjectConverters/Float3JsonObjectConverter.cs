using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3JsonObjectConverter : Float3JsonConverter
{
    public Float3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
