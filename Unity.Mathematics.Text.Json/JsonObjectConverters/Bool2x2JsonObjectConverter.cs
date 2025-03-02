using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x2JsonObjectConverter : Bool2x2JsonConverter
{
    public Bool2x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
