using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x2JsonObjectConverter : Uint2x2JsonConverter
{
    public Uint2x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
