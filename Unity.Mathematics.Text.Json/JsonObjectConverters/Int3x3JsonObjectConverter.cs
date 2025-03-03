using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x3JsonObjectConverter : Int3x3JsonConverter
{
    public Int3x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
