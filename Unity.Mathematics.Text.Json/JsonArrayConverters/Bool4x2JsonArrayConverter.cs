using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x2JsonArrayConverter : Bool4x2JsonConverter
{
    public Bool4x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
