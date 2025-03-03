using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x3JsonObjectConverter : Float2x3JsonConverter
{
    public Float2x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
