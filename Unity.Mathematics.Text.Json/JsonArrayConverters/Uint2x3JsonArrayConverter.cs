using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x3JsonArrayConverter : Uint2x3JsonConverter
{
    public Uint2x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
