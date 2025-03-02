using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x4JsonArrayConverter : Float2x4JsonConverter
{
    public Float2x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
