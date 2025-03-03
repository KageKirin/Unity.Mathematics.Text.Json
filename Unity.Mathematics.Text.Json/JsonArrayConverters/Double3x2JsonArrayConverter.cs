using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x2JsonArrayConverter : Double3x2JsonConverter
{
    public Double3x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
