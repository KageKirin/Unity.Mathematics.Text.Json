using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4JsonObjectConverter : Bool4JsonConverter
{
    public Bool4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
