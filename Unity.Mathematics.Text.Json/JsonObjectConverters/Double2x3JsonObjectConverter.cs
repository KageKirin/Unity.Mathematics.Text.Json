using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x3JsonObjectConverter : Double2x3JsonConverter
{
    public Double2x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
