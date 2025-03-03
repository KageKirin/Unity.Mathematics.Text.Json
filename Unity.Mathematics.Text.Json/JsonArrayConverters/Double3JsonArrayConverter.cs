using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3JsonArrayConverter : Double3JsonConverter
{
    public Double3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
