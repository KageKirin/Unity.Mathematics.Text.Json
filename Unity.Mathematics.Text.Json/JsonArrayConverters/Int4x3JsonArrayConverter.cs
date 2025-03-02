using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x3JsonArrayConverter : Int4x3JsonConverter
{
    public Int4x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
