using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x3JsonArrayConverter : Double2x3JsonConverter
{
    public Double2x3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
