using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x3JsonArrayConverter : Int2x3JsonConverter
{
    public Int2x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
