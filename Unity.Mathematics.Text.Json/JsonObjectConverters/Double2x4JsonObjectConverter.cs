using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x4JsonObjectConverter : Double2x4JsonConverter
{
    public Double2x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
