using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x4JsonObjectConverter : Uint3x4JsonConverter
{
    public Uint3x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
