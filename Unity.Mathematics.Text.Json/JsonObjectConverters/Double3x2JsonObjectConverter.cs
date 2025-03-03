using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x2JsonObjectConverter : Double3x2JsonConverter
{
    public Double3x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
