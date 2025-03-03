using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2JsonObjectConverter : Uint2JsonConverter
{
    public Uint2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
