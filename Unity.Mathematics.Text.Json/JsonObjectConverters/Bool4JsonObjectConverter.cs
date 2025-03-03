using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4JsonObjectConverter : Bool4JsonConverter
{
    public Bool4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
