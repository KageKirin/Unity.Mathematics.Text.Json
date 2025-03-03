using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Int4JsonArrayConverter : Int4JsonConverter
{
    public Int4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
