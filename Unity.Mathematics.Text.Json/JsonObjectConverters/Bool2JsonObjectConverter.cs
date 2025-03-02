using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2JsonObjectConverter : Bool2JsonConverter
{
    public Bool2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
