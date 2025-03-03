using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x2JsonArrayConverter : Int3x2JsonConverter
{
    public Int3x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
