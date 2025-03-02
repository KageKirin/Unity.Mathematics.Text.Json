using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x2JsonArrayConverter : Int2x2JsonConverter
{
    public Int2x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
