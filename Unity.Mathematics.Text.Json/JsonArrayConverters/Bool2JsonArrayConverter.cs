using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2JsonArrayConverter : Bool2JsonConverter
{
    public Bool2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
