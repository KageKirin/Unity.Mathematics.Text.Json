using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x2JsonObjectConverter : Double4x2JsonConverter
{
    public Double4x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
