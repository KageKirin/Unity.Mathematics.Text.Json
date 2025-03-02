using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x4JsonArrayConverter : Int2x4JsonConverter
{
    public Int2x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
