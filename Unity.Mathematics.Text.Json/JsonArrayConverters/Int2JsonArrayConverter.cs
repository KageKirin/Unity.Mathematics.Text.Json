using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2JsonArrayConverter : Int2JsonConverter
{
    public Int2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
