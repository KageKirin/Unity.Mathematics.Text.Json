using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint2x3JsonObjectConverter : Uint2x3JsonConverter
{
    public Uint2x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
