using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2JsonObjectConverter : Int2JsonConverter
{
    public Int2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
