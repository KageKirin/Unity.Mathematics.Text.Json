using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3x4JsonObjectConverter : Uint3x4JsonConverter
{
    public Uint3x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
