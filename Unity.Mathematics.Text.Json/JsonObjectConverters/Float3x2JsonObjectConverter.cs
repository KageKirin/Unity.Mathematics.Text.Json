using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x2JsonObjectConverter : Float3x2JsonConverter
{
    public Float3x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
