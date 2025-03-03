using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool4JsonArrayConverter : Bool4JsonConverter
{
    public Bool4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
