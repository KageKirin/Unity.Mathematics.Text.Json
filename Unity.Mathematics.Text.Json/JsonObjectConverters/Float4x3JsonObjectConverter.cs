using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x3JsonObjectConverter : Float4x3JsonConverter
{
    public Float4x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
