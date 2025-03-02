using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4JsonObjectConverter : Double4JsonConverter
{
    public Double4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
