using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4x2JsonArrayConverter : Float4x2JsonConverter
{
    public Float4x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
