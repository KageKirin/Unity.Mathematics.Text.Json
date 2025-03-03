using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x3JsonArrayConverter : Float3x3JsonConverter
{
    public Float3x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
