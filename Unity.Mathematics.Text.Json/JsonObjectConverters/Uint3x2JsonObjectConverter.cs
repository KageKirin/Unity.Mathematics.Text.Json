using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x2JsonObjectConverter : Uint3x2JsonConverter
{
    public Uint3x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
