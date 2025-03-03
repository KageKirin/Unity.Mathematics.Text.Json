using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x3JsonArrayConverter : Bool2x3JsonConverter
{
    public Bool2x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
