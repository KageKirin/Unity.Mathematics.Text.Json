using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2JsonArrayConverter : Int2JsonConverter
{
    public Int2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
