using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x3JsonObjectConverter : Uint4x3JsonConverter
{
    public Uint4x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
