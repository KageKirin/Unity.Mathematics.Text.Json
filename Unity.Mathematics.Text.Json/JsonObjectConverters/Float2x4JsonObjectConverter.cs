using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float2x4JsonObjectConverter : Float2x4JsonConverter
{
    public Float2x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
