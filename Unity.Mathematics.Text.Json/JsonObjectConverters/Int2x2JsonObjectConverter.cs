using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x2JsonObjectConverter : Int2x2JsonConverter
{
    public Int2x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
