using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4JsonArrayConverter : Uint4JsonConverter
{
    public Uint4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
