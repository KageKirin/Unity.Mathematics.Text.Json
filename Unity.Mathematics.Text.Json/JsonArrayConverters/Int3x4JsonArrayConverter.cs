using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x4JsonArrayConverter : Int3x4JsonConverter
{
    public Int3x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
