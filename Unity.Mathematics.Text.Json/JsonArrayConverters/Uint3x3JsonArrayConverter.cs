using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x3JsonArrayConverter : Uint3x3JsonConverter
{
    public Uint3x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
