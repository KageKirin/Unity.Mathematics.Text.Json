using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x2JsonArrayConverter : Double2x2JsonConverter
{
    public Double2x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
