using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2JsonArrayConverter : Double2JsonConverter
{
    public Double2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
