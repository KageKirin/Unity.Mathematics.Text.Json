using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x4JsonObjectConverter : Int2x4JsonConverter
{
    public Int2x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
