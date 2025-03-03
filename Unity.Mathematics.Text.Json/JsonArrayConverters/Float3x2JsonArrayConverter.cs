using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x2JsonArrayConverter : Float3x2JsonConverter
{
    public Float3x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
