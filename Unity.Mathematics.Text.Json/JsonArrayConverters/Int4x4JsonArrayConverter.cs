using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x4JsonArrayConverter : Int4x4JsonConverter
{
    public Int4x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
