using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double3JsonObjectConverter : Double3JsonConverter
{
    public Double3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
