using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2JsonArrayConverter : Uint2JsonConverter
{
    public Uint2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
