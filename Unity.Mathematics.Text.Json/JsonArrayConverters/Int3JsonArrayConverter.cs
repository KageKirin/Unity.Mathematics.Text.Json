using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3JsonArrayConverter : Int3JsonConverter
{
    public Int3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
