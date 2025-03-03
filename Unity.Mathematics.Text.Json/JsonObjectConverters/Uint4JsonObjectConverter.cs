using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4JsonObjectConverter : Uint4JsonConverter
{
    public Uint4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
