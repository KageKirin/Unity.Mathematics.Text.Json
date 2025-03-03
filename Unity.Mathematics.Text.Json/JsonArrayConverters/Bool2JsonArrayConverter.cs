using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2JsonArrayConverter : Bool2JsonConverter
{
    public Bool2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
