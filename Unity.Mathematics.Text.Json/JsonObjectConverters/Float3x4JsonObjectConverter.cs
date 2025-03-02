using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Float3x4JsonObjectConverter : Float3x4JsonConverter
{
    public Float3x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
