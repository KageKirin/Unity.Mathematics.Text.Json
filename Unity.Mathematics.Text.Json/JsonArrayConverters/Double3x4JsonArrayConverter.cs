using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x4JsonArrayConverter : Double3x4JsonConverter
{
    public Double3x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
