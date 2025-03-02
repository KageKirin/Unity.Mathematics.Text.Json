using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x3JsonArrayConverter : Float2x3JsonConverter
{
    public Float2x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
