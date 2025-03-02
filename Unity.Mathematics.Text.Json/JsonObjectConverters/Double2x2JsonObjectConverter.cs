using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x2JsonObjectConverter : Double2x2JsonConverter
{
    public Double2x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
