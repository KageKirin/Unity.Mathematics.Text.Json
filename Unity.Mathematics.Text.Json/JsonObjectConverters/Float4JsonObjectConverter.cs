using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float4JsonObjectConverter : Float4JsonConverter
{
    public Float4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
