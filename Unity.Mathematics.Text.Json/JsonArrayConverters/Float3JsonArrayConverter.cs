using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3JsonArrayConverter : Float3JsonConverter
{
    public Float3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
