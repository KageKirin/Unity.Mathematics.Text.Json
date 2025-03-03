using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x3JsonObjectConverter : Int3x3JsonConverter
{
    public Int3x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
