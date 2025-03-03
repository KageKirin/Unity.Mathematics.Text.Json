using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x3JsonObjectConverter : Bool2x3JsonConverter
{
    public Bool2x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
