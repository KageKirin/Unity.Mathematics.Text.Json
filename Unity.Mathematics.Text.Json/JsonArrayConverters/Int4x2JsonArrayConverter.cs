using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x2JsonArrayConverter : Int4x2JsonConverter
{
    public Int4x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
