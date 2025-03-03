using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3JsonArrayConverter : Int3JsonConverter
{
    public Int3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
