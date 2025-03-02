using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool2x4JsonObjectConverter : Bool2x4JsonConverter
{
    public Bool2x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
