using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x2JsonObjectConverter : Float4x2JsonConverter
{
    public Float4x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
