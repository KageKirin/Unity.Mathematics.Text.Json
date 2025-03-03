using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x3JsonObjectConverter : Bool2x3JsonConverter
{
    public Bool2x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
