using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x2JsonArrayConverter : Uint4x2JsonConverter
{
    public Uint4x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
