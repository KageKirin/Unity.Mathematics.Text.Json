using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3JsonObjectConverter : Int3JsonConverter
{
    public Int3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
