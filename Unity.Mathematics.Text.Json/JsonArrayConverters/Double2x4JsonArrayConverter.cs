using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x4JsonArrayConverter : Double2x4JsonConverter
{
    public Double2x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
