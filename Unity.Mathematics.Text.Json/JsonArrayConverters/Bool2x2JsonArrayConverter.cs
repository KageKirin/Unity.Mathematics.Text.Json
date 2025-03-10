using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x2JsonArrayConverter : Bool2x2JsonConverter
{
    public Bool2x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
