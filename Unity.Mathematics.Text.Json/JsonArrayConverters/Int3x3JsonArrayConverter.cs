using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x3JsonArrayConverter : Int3x3JsonConverter
{
    public Int3x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
