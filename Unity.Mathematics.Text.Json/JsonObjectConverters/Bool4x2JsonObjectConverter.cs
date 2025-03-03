using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x2JsonObjectConverter : Bool4x2JsonConverter
{
    public Bool4x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
