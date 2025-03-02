using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x4JsonArrayConverter : Uint4x4JsonConverter
{
    public Uint4x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
