using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x3JsonObjectConverter : Uint3x3JsonConverter
{
    public Uint3x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
