using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4JsonArrayConverter : Bool4JsonConverter
{
    public Bool4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
