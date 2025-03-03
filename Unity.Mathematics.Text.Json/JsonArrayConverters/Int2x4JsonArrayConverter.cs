using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x4JsonArrayConverter : Int2x4JsonConverter
{
    public Int2x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
