using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x3JsonArrayConverter : Int3x3JsonConverter
{
    public Int3x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
