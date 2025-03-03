using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int3x4JsonObjectConverter : Int3x4JsonConverter
{
    public Int3x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
