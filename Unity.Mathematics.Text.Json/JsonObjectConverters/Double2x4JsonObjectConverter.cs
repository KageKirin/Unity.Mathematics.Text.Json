using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Double2x4JsonObjectConverter : Double2x4JsonConverter
{
    public Double2x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
