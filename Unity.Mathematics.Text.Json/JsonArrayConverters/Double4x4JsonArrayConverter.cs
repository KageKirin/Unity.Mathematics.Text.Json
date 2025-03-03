using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x4JsonArrayConverter : Double4x4JsonConverter
{
    public Double4x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
