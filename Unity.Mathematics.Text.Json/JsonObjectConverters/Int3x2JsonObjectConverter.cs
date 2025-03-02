using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x2JsonObjectConverter : Int3x2JsonConverter
{
    public Int3x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
