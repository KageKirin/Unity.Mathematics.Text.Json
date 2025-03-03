using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4x3JsonArrayConverter : Double4x3JsonConverter
{
    public Double4x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
