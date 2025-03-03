using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x2JsonObjectConverter : Int3x2JsonConverter
{
    public Int3x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
