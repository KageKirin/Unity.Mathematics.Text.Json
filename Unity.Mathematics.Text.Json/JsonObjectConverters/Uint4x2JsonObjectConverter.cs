using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x2JsonObjectConverter : Uint4x2JsonConverter
{
    public Uint4x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
