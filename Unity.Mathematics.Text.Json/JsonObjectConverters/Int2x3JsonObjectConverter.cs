using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int2x3JsonObjectConverter : Int2x3JsonConverter
{
    public Int2x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
