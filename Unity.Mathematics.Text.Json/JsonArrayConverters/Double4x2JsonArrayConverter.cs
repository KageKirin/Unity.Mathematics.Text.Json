using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x2JsonArrayConverter : Double4x2JsonConverter
{
    public Double4x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
