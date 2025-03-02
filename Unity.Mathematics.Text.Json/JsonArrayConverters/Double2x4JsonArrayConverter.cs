using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x4JsonArrayConverter : Double2x4JsonConverter
{
    public Double2x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
