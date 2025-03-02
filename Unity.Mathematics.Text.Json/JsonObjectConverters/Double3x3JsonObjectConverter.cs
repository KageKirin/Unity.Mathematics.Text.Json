using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x3JsonObjectConverter : Double3x3JsonConverter
{
    public Double3x3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
