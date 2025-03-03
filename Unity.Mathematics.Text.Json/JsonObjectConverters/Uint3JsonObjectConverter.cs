using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3JsonObjectConverter : Uint3JsonConverter
{
    public Uint3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
