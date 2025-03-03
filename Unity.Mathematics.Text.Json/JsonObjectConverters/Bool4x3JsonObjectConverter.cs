using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x3JsonObjectConverter : Bool4x3JsonConverter
{
    public Bool4x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
