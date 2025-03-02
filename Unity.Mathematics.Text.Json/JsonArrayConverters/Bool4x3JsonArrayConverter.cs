using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x3JsonArrayConverter : Bool4x3JsonConverter
{
    public Bool4x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
