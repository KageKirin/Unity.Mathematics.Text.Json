using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x3JsonArrayConverter : Double3x3JsonConverter
{
    public Double3x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
