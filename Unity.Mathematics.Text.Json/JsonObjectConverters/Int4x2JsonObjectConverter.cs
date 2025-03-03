using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x2JsonObjectConverter : Int4x2JsonConverter
{
    public Int4x2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
