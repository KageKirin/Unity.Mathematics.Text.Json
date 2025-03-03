using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x2JsonObjectConverter : Bool2x2JsonConverter
{
    public Bool2x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
