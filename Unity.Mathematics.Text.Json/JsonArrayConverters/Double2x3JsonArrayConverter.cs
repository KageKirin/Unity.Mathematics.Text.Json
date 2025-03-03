using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x3JsonArrayConverter : Double2x3JsonConverter
{
    public Double2x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
