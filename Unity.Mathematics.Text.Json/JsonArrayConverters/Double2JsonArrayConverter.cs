using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2JsonArrayConverter : Double2JsonConverter
{
    public Double2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
