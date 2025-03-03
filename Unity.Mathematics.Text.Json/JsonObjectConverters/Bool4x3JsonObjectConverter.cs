using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x3JsonObjectConverter : Bool4x3JsonConverter
{
    public Bool4x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
