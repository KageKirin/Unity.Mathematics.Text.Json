using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x2JsonArrayConverter : Uint2x2JsonConverter
{
    public Uint2x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
