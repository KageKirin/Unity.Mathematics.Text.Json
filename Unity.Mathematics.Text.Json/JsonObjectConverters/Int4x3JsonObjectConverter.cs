using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x3JsonObjectConverter : Int4x3JsonConverter
{
    public Int4x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
