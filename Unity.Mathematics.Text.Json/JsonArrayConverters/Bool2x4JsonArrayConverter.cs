using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x4JsonArrayConverter : Bool2x4JsonConverter
{
    public Bool2x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
