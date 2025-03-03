using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4JsonArrayConverter : Float4JsonConverter
{
    public Float4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
