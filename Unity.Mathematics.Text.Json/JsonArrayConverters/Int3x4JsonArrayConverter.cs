using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x4JsonArrayConverter : Int3x4JsonConverter
{
    public Int3x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
