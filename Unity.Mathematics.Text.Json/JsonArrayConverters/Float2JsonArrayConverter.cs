using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2JsonArrayConverter : Float2JsonConverter
{
    public Float2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
