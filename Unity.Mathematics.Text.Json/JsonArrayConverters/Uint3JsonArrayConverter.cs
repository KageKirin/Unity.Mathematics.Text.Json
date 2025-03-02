using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3JsonArrayConverter : Uint3JsonConverter
{
    public Uint3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
