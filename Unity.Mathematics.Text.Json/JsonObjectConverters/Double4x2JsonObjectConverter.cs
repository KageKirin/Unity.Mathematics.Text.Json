using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x2JsonObjectConverter : Double4x2JsonConverter
{
    public Double4x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
