using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x4JsonObjectConverter : Double4x4JsonConverter
{
    public Double4x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
