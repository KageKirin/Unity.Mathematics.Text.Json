using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4JsonArrayConverter : Double4JsonConverter
{
    public Double4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
