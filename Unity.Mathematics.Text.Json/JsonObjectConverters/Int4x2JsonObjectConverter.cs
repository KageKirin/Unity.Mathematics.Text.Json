using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x2JsonObjectConverter : Int4x2JsonConverter
{
    public Int4x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
