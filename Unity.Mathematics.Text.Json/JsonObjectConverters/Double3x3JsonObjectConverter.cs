using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3x3JsonObjectConverter : Double3x3JsonConverter
{
    public Double3x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
