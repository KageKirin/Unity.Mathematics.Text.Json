using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x4JsonObjectConverter : Double3x4JsonConverter
{
    public Double3x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
