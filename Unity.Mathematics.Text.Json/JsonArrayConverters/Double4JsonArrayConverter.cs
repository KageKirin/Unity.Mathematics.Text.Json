using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double4JsonArrayConverter : Double4JsonConverter
{
    public Double4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
