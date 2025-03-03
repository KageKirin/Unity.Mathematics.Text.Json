using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2JsonObjectConverter : Bool2JsonConverter
{
    public Bool2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
