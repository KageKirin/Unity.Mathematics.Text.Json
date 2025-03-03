using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4JsonObjectConverter : Int4JsonConverter
{
    public Int4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
