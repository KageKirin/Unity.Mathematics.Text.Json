using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x2JsonObjectConverter : Int2x2JsonConverter
{
    public Int2x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
