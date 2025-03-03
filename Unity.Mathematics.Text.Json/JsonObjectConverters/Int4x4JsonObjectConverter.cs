using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4x4JsonObjectConverter : Int4x4JsonConverter
{
    public Int4x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
