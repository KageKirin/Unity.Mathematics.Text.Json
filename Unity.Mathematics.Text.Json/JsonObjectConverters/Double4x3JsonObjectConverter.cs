using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x3JsonObjectConverter : Double4x3JsonConverter
{
    public Double4x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
