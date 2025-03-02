using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x4JsonArrayConverter : Uint2x4JsonConverter
{
    public Uint2x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
