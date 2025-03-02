using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4x4JsonObjectConverter : Bool4x4JsonConverter
{
    public Bool4x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
