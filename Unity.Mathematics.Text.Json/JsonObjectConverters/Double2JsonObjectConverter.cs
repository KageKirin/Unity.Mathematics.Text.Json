using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2JsonObjectConverter : Double2JsonConverter
{
    public Double2JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
