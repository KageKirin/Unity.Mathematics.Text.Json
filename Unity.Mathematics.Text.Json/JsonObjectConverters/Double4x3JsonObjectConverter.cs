using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x3JsonObjectConverter : Double4x3JsonConverter
{
    public Double4x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
