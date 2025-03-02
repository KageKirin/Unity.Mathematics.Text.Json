using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2JsonObjectConverter : Float2JsonConverter
{
    public Float2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
