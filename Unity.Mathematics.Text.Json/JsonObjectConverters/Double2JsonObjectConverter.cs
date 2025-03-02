using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2JsonObjectConverter : Double2JsonConverter
{
    public Double2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
