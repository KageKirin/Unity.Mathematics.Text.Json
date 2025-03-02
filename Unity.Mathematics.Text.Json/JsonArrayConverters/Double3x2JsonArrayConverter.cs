using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x2JsonArrayConverter : Double3x2JsonConverter
{
    public Double3x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
