using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x4JsonArrayConverter : Bool4x4JsonConverter
{
    public Bool4x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
