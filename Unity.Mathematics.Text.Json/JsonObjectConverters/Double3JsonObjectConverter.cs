using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3JsonObjectConverter : Double3JsonConverter
{
    public Double3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
