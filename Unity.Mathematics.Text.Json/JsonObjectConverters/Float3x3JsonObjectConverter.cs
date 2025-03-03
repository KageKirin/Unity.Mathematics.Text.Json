using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x3JsonObjectConverter : Float3x3JsonConverter
{
    public Float3x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
