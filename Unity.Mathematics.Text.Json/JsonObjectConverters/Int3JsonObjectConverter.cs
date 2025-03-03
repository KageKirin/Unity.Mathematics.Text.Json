using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3JsonObjectConverter : Int3JsonConverter
{
    public Int3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
