using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x2JsonObjectConverter : Double3x2JsonConverter
{
    public Double3x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
