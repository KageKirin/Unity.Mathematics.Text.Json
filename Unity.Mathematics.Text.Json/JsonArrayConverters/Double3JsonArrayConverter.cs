using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3JsonArrayConverter : Double3JsonConverter
{
    public Double3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
