using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x4JsonObjectConverter : Float3x4JsonConverter
{
    public Float3x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
