using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4JsonArrayConverter : Int4JsonConverter
{
    public Int4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
