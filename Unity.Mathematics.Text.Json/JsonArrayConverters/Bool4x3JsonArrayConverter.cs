using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x3JsonArrayConverter : Bool4x3JsonConverter
{
    public Bool4x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
