using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3JsonObjectConverter : Float3JsonConverter
{
    public Float3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
