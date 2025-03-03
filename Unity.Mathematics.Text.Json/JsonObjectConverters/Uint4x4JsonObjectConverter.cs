using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4x4JsonObjectConverter : Uint4x4JsonConverter
{
    public Uint4x4JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
