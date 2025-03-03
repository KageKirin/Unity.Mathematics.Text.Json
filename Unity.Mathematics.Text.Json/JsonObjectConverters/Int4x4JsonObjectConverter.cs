using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x4JsonObjectConverter : Int4x4JsonConverter
{
    public Int4x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
