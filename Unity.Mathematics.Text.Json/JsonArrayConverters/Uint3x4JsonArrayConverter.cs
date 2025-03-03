using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x4JsonArrayConverter : Uint3x4JsonConverter
{
    public Uint3x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
