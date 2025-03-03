using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x2JsonObjectConverter : Bool4x2JsonConverter
{
    public Bool4x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
